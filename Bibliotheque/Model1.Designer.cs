﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace Bibliotheque
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class bibliothequeEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new bibliothequeEntities object using the connection string found in the 'bibliothequeEntities' section of the application configuration file.
        /// </summary>
        public bibliothequeEntities() : base("name=bibliothequeEntities", "bibliothequeEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new bibliothequeEntities object.
        /// </summary>
        public bibliothequeEntities(string connectionString) : base(connectionString, "bibliothequeEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new bibliothequeEntities object.
        /// </summary>
        public bibliothequeEntities(EntityConnection connection) : base(connection, "bibliothequeEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
    }
    

    #endregion
    
    
}
