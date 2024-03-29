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
using System.Linq;
[assembly: EdmSchemaAttribute()]

namespace DBConnection
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class DBHomeContainer : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new DBHomeContainer object using the connection string found in the 'DBHomeContainer' section of the application configuration file.
        /// </summary>
        public DBHomeContainer() : base("name=DBHomeContainer", "DBHomeContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DBHomeContainer object.
        /// </summary>
        public DBHomeContainer(string connectionString) : base(connectionString, "DBHomeContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DBHomeContainer object.
        /// </summary>
        public DBHomeContainer(EntityConnection connection) : base(connection, "DBHomeContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Image> ImageSet
        {
            get
            {
                if ((_ImageSet == null))
                {
                    _ImageSet = base.CreateObjectSet<Image>("ImageSet");
                }
                return _ImageSet;
            }
        }
        private ObjectSet<Image> _ImageSet;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the ImageSet EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToImageSet(Image image)
        {
            base.AddObject("ImageSet", image);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DBHome", Name="Image")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Image : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Image object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="title">Initial value of the Title property.</param>
        /// <param name="description">Initial value of the Description property.</param>
        /// <param name="link">Initial value of the Link property.</param>
        /// <param name="data">Initial value of the Data property.</param>
        public static Image CreateImage(global::System.Guid id, global::System.String title, global::System.String description, global::System.String link, global::System.Byte[] data)
        {
            Image image = new Image();
            image.Id = id;
            image.Title = title;
            image.Description = description;
            image.Link = link;
            image.Data = data;
            return image;
        }

        public static Image GetImageInstance(Guid id)
        {
            return (from oImage 
                    in ContextDAO.DataContext.ImageSet 
                    where oImage.Id == id 
                    select oImage).FirstOrDefault();
        }
        #endregion
         
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Guid _Id;
        partial void OnIdChanging(global::System.Guid value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Link
        {
            get
            {
                return _Link;
            }
            set
            {
                OnLinkChanging(value);
                ReportPropertyChanging("Link");
                _Link = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Link");
                OnLinkChanged();
            }
        }
        private global::System.String _Link;
        partial void OnLinkChanging(global::System.String value);
        partial void OnLinkChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Byte[] Data
        {
            get
            {
                return StructuralObject.GetValidValue(_Data);
            }
            set
            {
                OnDataChanging(value);
                ReportPropertyChanging("Data");
                _Data = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Data");
                OnDataChanged();
            }
        }
        private global::System.Byte[] _Data;
        partial void OnDataChanging(global::System.Byte[] value);
        partial void OnDataChanged();

        #endregion
    
    }

    #endregion
    
}
