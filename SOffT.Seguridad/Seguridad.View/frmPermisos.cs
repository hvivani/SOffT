/*  
    frmPermisos.cs

    Author:
    Hernan Vivani <hernan@vivani.com.ar> - http://hvivani.com.ar

    Copyright © SOffT 2008 - http://www.sofft.com.ar

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Data.Common;
using System.Windows.Forms;
using System.Xml;
using Model;
using Sofft.Utils;
using Sofft.ViewComunes;

namespace Seguridad.View
{
    public partial class frmPermisos : Form
    {
        //TODO Reemplazar constante por el manejo generico de modulos. 
        //COMENT idModulo = 2 corresponde al modulo sueldos
        private int idModulo = 2;

        //private const string permisosXML = "Permisos.xml";
        private int idUsuario;

        public frmPermisos()
        { 
            InitializeComponent();
            Modulo.PermisosXML = "Permisos.xml";
        }

        private void cargarListaPermisos()
        {
            try
            {
                // SECTION 1. Create a DOM Document and load the XML data into it.
                XmlDocument dom = new XmlDocument();
                dom.Load(Application.StartupPath + System.IO.Path.DirectorySeparatorChar + Modulo.PermisosXML);

                // SECTION 2. Initialize the TreeView control.
                treeViewPermisos.Nodes.Clear();
                treeViewPermisos.Nodes.Add(new TreeNode(dom.DocumentElement.Name));
                TreeNode tNode = new TreeNode();
                tNode = treeViewPermisos.Nodes[0];

                // SECTION 3. Populate the TreeView with the DOM nodes.
                agregarNodo(dom.DocumentElement, tNode);
                //treeViewPermisos.ExpandAll();
                treeViewPermisos.Nodes[0].Checked = true;
                treeViewPermisos.Nodes[0].Expand();
                treeViewPermisos.SelectedNode = treeViewPermisos.Nodes[0];
            }
            catch (XmlException xmlEx)
            { MessageBox.Show(xmlEx.Message); }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void agregarNodo(XmlNode inXmlNode, TreeNode inTreeNode)
        {
            XmlNode xNode;
            TreeNode tNode;
            XmlNodeList nodeList;
            int i;

            // Loop through the XML nodes until the leaf is reached.
            // Add the nodes to the TreeView during the looping process.
            if (inXmlNode.HasChildNodes)
            {
                nodeList = inXmlNode.ChildNodes;
                for (i = 0; i <= nodeList.Count - 1; i++)
                {
                    xNode = inXmlNode.ChildNodes[i];
                    inTreeNode.Nodes.Add(xNode.Attributes["Nombre"].Value);
                    tNode = inTreeNode.Nodes[i];
                    agregarNodo(xNode, tNode);
                }
            }
            else
            {
                // Here you need to pull the data from the XmlNode based on the
                // type of node, whether attribute values are required, and so forth.
                inTreeNode.Text = inXmlNode.Attributes["Nombre"].Value;
            }
        }

        private int getIdEmpleado()
        {
            if (this.cbAsociarEmpleado.Checked)
            { return Convert.ToInt32(this.cmbEmpleados.SelectedValue); }
            else
            { return 0; }
        }       

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            DB.ejecutarProceso(TipoComando.SP,"permisosEliminar", "idUsuario", cmbUsuarios.SelectedValue, "idModulo", idModulo);
            if (treeViewPermisos.Nodes.Count > 0)
            {
                foreach (TreeNode nodo in treeViewPermisos.Nodes)
                { grabar(nodo.Nodes, idModulo.ToString(), idModulo); }
            }
            DB.ejecutarProceso(TipoComando.SP, "usuariosActualizar",
                "idUsuario", this.idUsuario,
                "nombre", this.cmbUsuarios.Text,
                "login", this.txtUsuario.Text,
                "password", this.txtPassword.Text,
                "documentos", this.cbDocumentos.Checked,
                "seguridad", this.cbSeguridad.Checked,
                "idEmpleado", this.getIdEmpleado(),
                "eliminado", this.cbDeshabilitar.Checked);
            MessageBox.Show("Ya se pueden utilizar los nuevos permisos");
        }

        private void grabar(TreeNodeCollection nodo, string nivel, int modulo)
        {
            if (nodo.Count > 0)
            {
                foreach (TreeNode nodoHijo in nodo)
                {
                    DB.ejecutarProceso(TipoComando.SP, "permisosActualizar",
                        "idModulo", modulo,
                        "idUsuario", cmbUsuarios.SelectedValue,
                        "nivel", nivel,
                        "indice", nodoHijo.Index,
                        "acceso", nodoHijo.Checked);
                    grabar(nodoHijo.Nodes, string.Concat(nivel, ".", nodoHijo.Index), modulo);
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        { this.Close(); }

        private void frmPermisos_Load(object sender, EventArgs e)
        {
            this.cargarListaPermisos();
            Controles.cargaComboBox(this.cmbEmpleados, "Apellido y Nombres", "idEmpleado", "empleadosConsultarParaCombo");
            Controles.cargaComboBox(this.cmbUsuarios, "nombre", "idusuario", "usuariosConsultarParaCombo");
        }

        private void cbAsociarEmpleado_CheckedChanged(object sender, EventArgs e)
        { cmbEmpleados.Enabled = cbAsociarEmpleado.Checked; }

        private void cmbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.idUsuario = Convert.ToInt32(cmbUsuarios.SelectedValue);
            //Consulto los datos del usuario, esto deberia estar encapsulado en el objeto usuario
            DbDataReader rs = null;
            rs = DB.ejecutarDataReader(TipoComando.SP, "usuariosConsultar", "idUsuario", cmbUsuarios.SelectedValue);
            if (rs.Read())
            {
                this.cbAsociarEmpleado.Checked = (Convert.ToInt32(rs["idEmpleado"]) > 0);
                if (this.cbAsociarEmpleado.Checked)
                    this.cmbEmpleados.SelectedValue = Convert.ToInt32(rs["idEmpleado"]);
                this.cbDocumentos.Checked = Convert.ToBoolean(rs["documentos"]);
                this.cbSeguridad.Checked = Convert.ToBoolean(rs["seguridad"]);
                this.txtPassword.Text = Convert.ToString(rs["password"]);
                this.txtUsuario.Text = Convert.ToString(rs["login"]);
                this.cbDeshabilitar.Checked = Convert.ToBoolean(rs["eliminado"]);
            }
            DB.desconectarDB();

            //Consulto los permisos del usuario, esto deberia estar encapsulado en el objeto usuario
            cargarListaPermisos();
            rs = DB.ejecutarDataReader(TipoComando.SP, "permisosConsultar", "idUsuario", cmbUsuarios.SelectedValue, "idModulo", idModulo);
            while (rs.Read())
            { cargarPermisos(Convert.ToString(rs["nivel"]), Convert.ToInt32(rs["indice"]), Convert.ToBoolean(rs["acceso"])); }
            DB.desconectarDB();
        }

        private void cargarPermisos(string nivel, int indice, Boolean valor)
        {
            string[] id = nivel.Split(".".ToCharArray());
            TreeNode nodo = treeViewPermisos.Nodes[0];
            for (int i = 1; i < id.Length; i++)
            { nodo = getNodo(nodo, Convert.ToInt32(id[i])); }
            try
            { nodo.Nodes[indice].Checked = valor; }
            catch (Exception)
            { MessageBox.Show("Revisar permisos del Nivel: " + nivel + " " + nodo.Text + ". El indice: " + indice + " no definido en el XML"); }
        }

        private TreeNode getNodo(TreeNode nodo, int indice)
        { return nodo.Nodes[indice]; }
    }
}