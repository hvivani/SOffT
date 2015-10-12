'  
'    EvalVariable.vb

'    Author:
'    Hernan Vivani <hernan@vivani.com.ar> - http://hvivani.com.ar

'    Copyright © SOffT 2010 - http://www.sofft.com.ar

'    This program is free software: you can redistribute it and/or modify
'    it under the terms of the GNU General Public License as published by
'    the Free Software Foundation, either version 3 of the License, or
'    (at your option) any later version.

'    This program is distributed in the hope that it will be useful,
'    but WITHOUT ANY WARRANTY; without even the implied warranty of
'    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'    GNU General Public License for more details.

'    You should have received a copy of the GNU General Public License
'    along with this program.  If not, see <http://www.gnu.org/licenses/>.
'*/


Public Class EvalVariable
   Implements iEvalValue

   Private mValue As Object
   Private mSystemType As System.Type

#Region "iEvalValue implementation"

   Public ReadOnly Property iEvalValue_value() As Object Implements iEvalValue.Value
      Get
         Return mValue
      End Get
   End Property

   Public ReadOnly Property SystemType() As System.Type Implements iEvalValue.SystemType
      Get
         Return mSystemType
      End Get
   End Property

#End Region

   Sub New(ByVal originalValue As Object, Optional ByVal systemType As System.Type = Nothing)
      mValue = originalValue
      If systemType Is Nothing Then
         If originalValue Is Nothing Then
            Throw New Exception("Cannot establish runtime type on variable <nothing>.")
         Else
            mSystemType = originalValue.GetType
         End If
      Else
         mSystemType = systemType
      End If
   End Sub

   Public Property Value() As Object
      Get
         Return mValue
      End Get
      Set(ByVal Value As Object)
         If Not Value Is mValue Then
            mValue = Value
            RaiseEvent ValueChanged(Me, New System.EventArgs)
         End If
      End Set
   End Property

   Public Event ValueChanged(ByVal Sender As Object, ByVal e As System.EventArgs) Implements iEvalValue.ValueChanged

End Class

