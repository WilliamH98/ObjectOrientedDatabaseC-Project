﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace ProjekLab
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class WatchDatabseEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new WatchDatabseEntities object using the connection string found in the 'WatchDatabseEntities' section of the application configuration file.
        /// </summary>
        public WatchDatabseEntities() : base("name=WatchDatabseEntities", "WatchDatabseEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new WatchDatabseEntities object.
        /// </summary>
        public WatchDatabseEntities(string connectionString) : base(connectionString, "WatchDatabseEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new WatchDatabseEntities object.
        /// </summary>
        public WatchDatabseEntities(EntityConnection connection) : base(connection, "WatchDatabseEntities")
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