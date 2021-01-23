//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DLaB.Xrm.Entities
{
	
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.0.1.7297")]
	public enum AzureServiceConnectionState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}
	
	/// <summary>
	/// Stores connection information for an Azure service
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("azureserviceconnection")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.0.1.7297")]
	public partial class AzureServiceConnection : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public struct Fields
		{
			public const string AccountKey = "accountkey";
			public const string AzureServiceConnectionId = "azureserviceconnectionid";
			public const string Id = "azureserviceconnectionid";
			public const string ConnectionType = "connectiontype";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string Description = "description";
			public const string LastConnectionStatusCode = "lastconnectionstatuscode";
			public const string LastConnectionTime = "lastconnectiontime";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string Name = "name";
			public const string OrganizationId = "organizationid";
			public const string ServiceUri = "serviceuri";
			public const string StateCode = "statecode";
			public const string StatusCode = "statuscode";
			public const string lk_azureserviceconnection_createdby = "lk_azureserviceconnection_createdby";
			public const string lk_azureserviceconnection_createdonbehalfby = "lk_azureserviceconnection_createdonbehalfby";
			public const string lk_azureserviceconnection_modifiedby = "lk_azureserviceconnection_modifiedby";
			public const string lk_azureserviceconnection_modifiedonbehalfby = "lk_azureserviceconnection_modifiedonbehalfby";
			public const string organization_azureserviceconnection = "organization_azureserviceconnection";
		}

		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public AzureServiceConnection() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "azureserviceconnection";
		
		public const int EntityTypeCode = 9936;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>
		/// Type the Azure account key.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountkey")]
		public string AccountKey
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("accountkey");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AccountKey");
				this.SetAttributeValue("accountkey", value);
				this.OnPropertyChanged("AccountKey");
			}
		}
		
		/// <summary>
		/// Unique identifier of the Azure service connection.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("azureserviceconnectionid")]
		public System.Nullable<System.Guid> AzureServiceConnectionId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("azureserviceconnectionid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AzureServiceConnectionId");
				this.SetAttributeValue("azureserviceconnectionid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("AzureServiceConnectionId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("azureserviceconnectionid")]
		public override System.Guid Id
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return base.Id;
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.AzureServiceConnectionId = value;
			}
		}
		
		/// <summary>
		/// Azure service connection type
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("connectiontype")]
		public Microsoft.Xrm.Sdk.OptionSetValue ConnectionType
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("connectiontype");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ConnectionType");
				this.SetAttributeValue("connectiontype", value);
				this.OnPropertyChanged("ConnectionType");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the Azure service connection.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedBy");
				this.SetAttributeValue("createdby", value);
				this.OnPropertyChanged("CreatedBy");
			}
		}
		
		/// <summary>
		/// Date and time when the Azure service connection was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedOn");
				this.SetAttributeValue("createdon", value);
				this.OnPropertyChanged("CreatedOn");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the Azure service connection.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedOnBehalfBy");
				this.SetAttributeValue("createdonbehalfby", value);
				this.OnPropertyChanged("CreatedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Enter a description of the Azure service connection.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
		public string Description
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("description");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Description");
				this.SetAttributeValue("description", value);
				this.OnPropertyChanged("Description");
			}
		}
		
		/// <summary>
		/// Shows the status of the last connection to the Azure service.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastconnectionstatuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue LastConnectionStatusCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("lastconnectionstatuscode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("LastConnectionStatusCode");
				this.SetAttributeValue("lastconnectionstatuscode", value);
				this.OnPropertyChanged("LastConnectionStatusCode");
			}
		}
		
		/// <summary>
		/// shows the time of the last connection to the Azure service.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastconnectiontime")]
		public System.Nullable<System.DateTime> LastConnectionTime
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastconnectiontime");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("LastConnectionTime");
				this.SetAttributeValue("lastconnectiontime", value);
				this.OnPropertyChanged("LastConnectionTime");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who modified the Azure service connection.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedBy");
				this.SetAttributeValue("modifiedby", value);
				this.OnPropertyChanged("ModifiedBy");
			}
		}
		
		/// <summary>
		/// Date and time when the Azure service connection was last modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedOn");
				this.SetAttributeValue("modifiedon", value);
				this.OnPropertyChanged("ModifiedOn");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who last modified the Azure service connection.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedOnBehalfBy");
				this.SetAttributeValue("modifiedonbehalfby", value);
				this.OnPropertyChanged("ModifiedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Type a logical name for the connection.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string Name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Name");
				this.SetAttributeValue("name", value);
				this.OnPropertyChanged("Name");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization associated with the Azure service connection.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// Type the service URL for the Azure service.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("serviceuri")]
		public string ServiceUri
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("serviceuri");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ServiceUri");
				this.SetAttributeValue("serviceuri", value);
				this.OnPropertyChanged("ServiceUri");
			}
		}
		
		/// <summary>
		/// Shows whether the Azure service connection is active or inactive.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<Entities.AzureServiceConnectionState> StateCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((Entities.AzureServiceConnectionState)(System.Enum.ToObject(typeof(Entities.AzureServiceConnectionState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StateCode");
				if ((value == null))
				{
					this.SetAttributeValue("statecode", null);
				}
				else
				{
					this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("StateCode");
			}
		}
		
		/// <summary>
		/// Select the Azure service connection's status.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue StatusCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StatusCode");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("StatusCode");
			}
		}
		
		/// <summary>
		/// 1:N azureserviceconnection_knowledgesearchmodel
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("azureserviceconnection_knowledgesearchmodel")]
		public System.Collections.Generic.IEnumerable<Entities.KnowledgeSearchModel> azureserviceconnection_knowledgesearchmodel
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Entities.KnowledgeSearchModel>("azureserviceconnection_knowledgesearchmodel", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("azureserviceconnection_knowledgesearchmodel");
				this.SetRelatedEntities<Entities.KnowledgeSearchModel>("azureserviceconnection_knowledgesearchmodel", null, value);
				this.OnPropertyChanged("azureserviceconnection_knowledgesearchmodel");
			}
		}
		
		/// <summary>
		/// 1:N azureserviceconnection_recommendationmodel
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("azureserviceconnection_recommendationmodel")]
		public System.Collections.Generic.IEnumerable<Entities.RecommendationModel> azureserviceconnection_recommendationmodel
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Entities.RecommendationModel>("azureserviceconnection_recommendationmodel", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("azureserviceconnection_recommendationmodel");
				this.SetRelatedEntities<Entities.RecommendationModel>("azureserviceconnection_recommendationmodel", null, value);
				this.OnPropertyChanged("azureserviceconnection_recommendationmodel");
			}
		}
		
		/// <summary>
		/// 1:N azureserviceconnection_topicmodel
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("azureserviceconnection_topicmodel")]
		public System.Collections.Generic.IEnumerable<Entities.TopicModel> azureserviceconnection_topicmodel
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Entities.TopicModel>("azureserviceconnection_topicmodel", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("azureserviceconnection_topicmodel");
				this.SetRelatedEntities<Entities.TopicModel>("azureserviceconnection_topicmodel", null, value);
				this.OnPropertyChanged("azureserviceconnection_topicmodel");
			}
		}
		
		/// <summary>
		/// N:1 lk_azureserviceconnection_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_azureserviceconnection_createdby")]
		public Entities.SystemUser lk_azureserviceconnection_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.SystemUser>("lk_azureserviceconnection_createdby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_azureserviceconnection_createdby");
				this.SetRelatedEntity<Entities.SystemUser>("lk_azureserviceconnection_createdby", null, value);
				this.OnPropertyChanged("lk_azureserviceconnection_createdby");
			}
		}
		
		/// <summary>
		/// N:1 lk_azureserviceconnection_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_azureserviceconnection_createdonbehalfby")]
		public Entities.SystemUser lk_azureserviceconnection_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.SystemUser>("lk_azureserviceconnection_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_azureserviceconnection_createdonbehalfby");
				this.SetRelatedEntity<Entities.SystemUser>("lk_azureserviceconnection_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_azureserviceconnection_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_azureserviceconnection_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_azureserviceconnection_modifiedby")]
		public Entities.SystemUser lk_azureserviceconnection_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.SystemUser>("lk_azureserviceconnection_modifiedby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_azureserviceconnection_modifiedby");
				this.SetRelatedEntity<Entities.SystemUser>("lk_azureserviceconnection_modifiedby", null, value);
				this.OnPropertyChanged("lk_azureserviceconnection_modifiedby");
			}
		}
		
		/// <summary>
		/// N:1 lk_azureserviceconnection_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_azureserviceconnection_modifiedonbehalfby")]
		public Entities.SystemUser lk_azureserviceconnection_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.SystemUser>("lk_azureserviceconnection_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_azureserviceconnection_modifiedonbehalfby");
				this.SetRelatedEntity<Entities.SystemUser>("lk_azureserviceconnection_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_azureserviceconnection_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 organization_azureserviceconnection
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_azureserviceconnection")]
		public Entities.Organization organization_azureserviceconnection
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.Organization>("organization_azureserviceconnection", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public AzureServiceConnection(object anonymousType) : 
				this()
		{
            foreach (var p in anonymousType.GetType().GetProperties())
            {
                var value = p.GetValue(anonymousType, null);
                var name = p.Name.ToLower();
            
                if (name.EndsWith("enum") && value.GetType().BaseType == typeof(System.Enum))
                {
                    value = new Microsoft.Xrm.Sdk.OptionSetValue((int) value);
                    name = name.Remove(name.Length - "enum".Length);
                }
            
                switch (name)
                {
                    case "id":
                        base.Id = (System.Guid)value;
                        Attributes["azureserviceconnectionid"] = base.Id;
                        break;
                    case "azureserviceconnectionid":
                        var id = (System.Nullable<System.Guid>) value;
                        if(id == null){ continue; }
                        base.Id = id.Value;
                        Attributes[name] = base.Id;
                        break;
                    case "formattedvalues":
                        // Add Support for FormattedValues
                        FormattedValues.AddRange((Microsoft.Xrm.Sdk.FormattedValueCollection)value);
                        break;
                    default:
                        Attributes[name] = value;
                        break;
                }
            }
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("connectiontype")]
		public virtual AzureServiceConnection_ConnectionType? ConnectionTypeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((AzureServiceConnection_ConnectionType?)(EntityOptionSetEnum.GetEnum(this, "connectiontype")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				ConnectionType = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastconnectionstatuscode")]
		public virtual AzureServiceConnection_LastConnectionStatusCode? LastConnectionStatusCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((AzureServiceConnection_LastConnectionStatusCode?)(EntityOptionSetEnum.GetEnum(this, "lastconnectionstatuscode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				LastConnectionStatusCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public virtual AzureServiceConnection_StatusCode? StatusCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((AzureServiceConnection_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				StatusCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
	}
}