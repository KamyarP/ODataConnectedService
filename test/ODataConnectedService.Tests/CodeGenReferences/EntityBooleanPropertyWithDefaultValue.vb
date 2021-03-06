'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On


'Generation date: 28.05.2020 18:57:56
Namespace Namespace1
    '''<summary>
    '''There are no comments for EntityContainer in the schema.
    '''</summary>
    Partial Public Class EntityContainer
        Inherits Global.Microsoft.OData.Client.DataServiceContext
        '''<summary>
        '''Initialize a new EntityContainer object.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")>  _
        Public Sub New(ByVal serviceRoot As Global.System.Uri)
            MyBase.New(serviceRoot, Global.Microsoft.OData.Client.ODataProtocolVersion.V4)
            Me.OnContextCreated
            Me.Format.LoadServiceModel = AddressOf GeneratedEdmModel.GetInstance
            Me.Format.UseJson()
        End Sub
        Partial Private Sub OnContextCreated()
        End Sub
        '''<summary>
        '''There are no comments for Set1 in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")>  _
        Public Overridable ReadOnly Property Set1() As Global.Microsoft.OData.Client.DataServiceQuery(Of EntityType)
            Get
                If (Me._Set1 Is Nothing) Then
                    Me._Set1 = MyBase.CreateQuery(Of EntityType)("Set1")
                End If
                Return Me._Set1
            End Get
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")>  _
        Private _Set1 As Global.Microsoft.OData.Client.DataServiceQuery(Of EntityType)
        '''<summary>
        '''There are no comments for Set1 in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")>  _
        Public Overridable Sub AddToSet1(ByVal entityType As EntityType)
            MyBase.AddObject("Set1", entityType)
        End Sub
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")>  _
        Private MustInherit Class GeneratedEdmModel
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")>  _
            Private Shared ParsedModel As Global.Microsoft.OData.Edm.IEdmModel = LoadModelFromString
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")>  _
            Private Const Edmx As String = "<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">" & _
 "  <edmx:DataServices>" & _
 "    <Schema Namespace=""Namespace1"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">" & _
 "      <EntityType Name=""EntityType"">" & _
 "        <Key>" & _
 "          <PropertyRef Name=""Id"" />" & _
 "        </Key>" & _
 "        <Property Name=""Id"" Type=""Edm.Int32"" Nullable=""false"" />" & _
 "        <Property Name=""TestBoolean"" Type=""Edm.Boolean"" Nullable=""false"" DefaultValue=""False"" />" & _
 "      </EntityType>" & _
 "      <EntityContainer Name=""EntityContainer"">" & _
 "        <EntitySet Name=""Set1"" EntityType=""Namespace1.EntityType"" />" & _
 "      </EntityContainer>" & _
 "    </Schema>" & _
 "  </edmx:DataServices>" & _
 "</edmx:Edmx>"
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")>  _
            Public Shared Function GetInstance() As Global.Microsoft.OData.Edm.IEdmModel
                Return ParsedModel
            End Function
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")>  _
            Private Shared Function LoadModelFromString() As Global.Microsoft.OData.Edm.IEdmModel
                Dim reader As Global.System.Xml.XmlReader = CreateXmlReader(Edmx)
                Try
                    Return Global.Microsoft.OData.Edm.Csdl.CsdlReader.Parse(reader)
                Finally
                    CType(reader,Global.System.IDisposable).Dispose
                End Try
            End Function
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")>  _
            Private Shared Function CreateXmlReader(ByVal edmxToParse As String) As Global.System.Xml.XmlReader
                Return Global.System.Xml.XmlReader.Create(New Global.System.IO.StringReader(edmxToParse))
            End Function
        End Class
    End Class
    '''<summary>
    '''There are no comments for EntityTypeSingle in the schema.
    '''</summary>
    Partial Public Class EntityTypeSingle
        Inherits Global.Microsoft.OData.Client.DataServiceQuerySingle(Of EntityType)
        ''' <summary>
        ''' Initialize a new EntityTypeSingle object.
        ''' </summary>
        Public Sub New(ByVal context As Global.Microsoft.OData.Client.DataServiceContext, ByVal path As String)
            MyBase.New(context, path)
        End Sub

        ''' <summary>
        ''' Initialize a new EntityTypeSingle object.
        ''' </summary>
        Public Sub New(ByVal context As Global.Microsoft.OData.Client.DataServiceContext, ByVal path As String, ByVal isComposable As Boolean)
            MyBase.New(context, path, isComposable)
        End Sub

        ''' <summary>
        ''' Initialize a new EntityTypeSingle object.
        ''' </summary>
        Public Sub New(ByVal query As Global.Microsoft.OData.Client.DataServiceQuerySingle(Of EntityType))
            MyBase.New(query)
        End Sub
    End Class
    '''<summary>
    '''There are no comments for EntityType in the schema.
    '''</summary>
    '''<KeyProperties>
    '''Id
    '''</KeyProperties>
    <Global.Microsoft.OData.Client.Key("Id")>  _
    Partial Public Class EntityType
        Inherits Global.Microsoft.OData.Client.BaseEntityType
        '''<summary>
        '''Create a new EntityType object.
        '''</summary>
        '''<param name="ID">Initial value of Id.</param>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")>  _
        Public Shared Function CreateEntityType(ByVal ID As Integer) As EntityType
            Dim entityType As EntityType = New EntityType()
            entityType.Id = ID
            Return entityType
        End Function
        '''<summary>
        '''There are no comments for Property Id in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")>  _
        Public Overridable Property Id() As Integer
            Get
                Return Me._Id
            End Get
            Set
                Me.OnIdChanging(value)
                Me._Id = value
                Me.OnIdChanged
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")>  _
        Private _Id As Integer
        Partial Private Sub OnIdChanging(ByVal value As Integer)
        End Sub
        Partial Private Sub OnIdChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property TestBoolean in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")>  _
        Public Overridable Property TestBoolean() As Boolean
            Get
                Return Me._TestBoolean
            End Get
            Set
                Me.OnTestBooleanChanging(value)
                Me._TestBoolean = value
                Me.OnTestBooleanChanged
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")>  _
        Private _TestBoolean As Boolean = False
        Partial Private Sub OnTestBooleanChanging(ByVal value As Boolean)
        End Sub
        Partial Private Sub OnTestBooleanChanged()
        End Sub
    End Class
    ''' <summary>
    ''' Class containing all extension methods
    ''' </summary>
    Public Module ExtensionMethods
        ''' <summary>
        ''' Get an entity of type Namespace1.EntityType as Namespace1.EntityTypeSingle specified by key from an entity set
        ''' </summary>
        ''' <param name="source">source entity set</param>
        ''' <param name="keys">dictionary with the names and values of keys</param>
        <Global.System.Runtime.CompilerServices.Extension()>
        Public Function ByKey(ByVal source As Global.Microsoft.OData.Client.DataServiceQuery(Of Namespace1.EntityType), ByVal keys As Global.System.Collections.Generic.IDictionary(Of String, Object)) As Namespace1.EntityTypeSingle
            Return New Namespace1.EntityTypeSingle(source.Context, source.GetKeyPath(Global.Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)))
        End Function
        ''' <summary>
        ''' Get an entity of type Namespace1.EntityType as Namespace1.EntityTypeSingle specified by key from an entity set
        ''' </summary>
        ''' <param name="source">source entity set</param>
        ''' <param name="id">The value of id</param>
        <Global.System.Runtime.CompilerServices.Extension()>
        Public Function ByKey(ByVal source As Global.Microsoft.OData.Client.DataServiceQuery(Of Namespace1.EntityType),
            id As Integer) As Namespace1.EntityTypeSingle
            Dim keys As Global.System.Collections.Generic.IDictionary(Of String, Object) = New Global.System.Collections.Generic.Dictionary(Of String, Object)() From
            {
                { "Id", id }
            }
            Return New Namespace1.EntityTypeSingle(source.Context, source.GetKeyPath(Global.Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)))
        End Function
    End Module
End Namespace
