﻿//------------------------------------------------------------------------------
// <auto-generated>
//    O código foi gerado a partir de um modelo.
//
//    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
//    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
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
#region Metadados de Relação EDM

[assembly: EdmRelationshipAttribute("db_microondasModel", "fk_tb_defdefault_potencia1", "potencia", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Model.potencia), "tb_defdefault", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Model.tb_defdefault), true)]
[assembly: EdmRelationshipAttribute("db_microondasModel", "fk_tb_alimentos_tb_defdefault", "tb_defdefault", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Model.tb_defdefault), "tb_alimentos", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Model.tb_alimentos), true)]

#endregion

namespace Model
{
    #region Contextos
    
    /// <summary>
    /// Nenhuma Documentação de Metadados disponível.
    /// </summary>
    public partial class Banco : ObjectContext
    {
        #region Construtores
    
        /// <summary>
        /// Inicializa um novo objeto Banco usando a cadeia de conexão localizada na seção 'Banco' do arquivo de configuração do aplicativo.
        /// </summary>
        public Banco() : base("name=Banco", "Banco")
        {
            this.ContextOptions.LazyLoadingEnabled = false;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicialize um novo objeto Banco.
        /// </summary>
        public Banco(string connectionString) : base(connectionString, "Banco")
        {
            this.ContextOptions.LazyLoadingEnabled = false;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicialize um novo objeto Banco.
        /// </summary>
        public Banco(EntityConnection connection) : base(connection, "Banco")
        {
            this.ContextOptions.LazyLoadingEnabled = false;
            OnContextCreated();
        }
    
        #endregion
    
        #region Métodos Parciais
    
        partial void OnContextCreated();
    
        #endregion
    
        #region Propriedades de ObjectSet
    
        /// <summary>
        /// Nenhuma Documentação de Metadados disponível.
        /// </summary>
        public ObjectSet<potencia> potencias
        {
            get
            {
                if ((_potencias == null))
                {
                    _potencias = base.CreateObjectSet<potencia>("potencias");
                }
                return _potencias;
            }
        }
        private ObjectSet<potencia> _potencias;
    
        /// <summary>
        /// Nenhuma Documentação de Metadados disponível.
        /// </summary>
        public ObjectSet<tb_alimentos> tb_alimentos
        {
            get
            {
                if ((_tb_alimentos == null))
                {
                    _tb_alimentos = base.CreateObjectSet<tb_alimentos>("tb_alimentos");
                }
                return _tb_alimentos;
            }
        }
        private ObjectSet<tb_alimentos> _tb_alimentos;
    
        /// <summary>
        /// Nenhuma Documentação de Metadados disponível.
        /// </summary>
        public ObjectSet<tb_defdefault> tb_defdefault
        {
            get
            {
                if ((_tb_defdefault == null))
                {
                    _tb_defdefault = base.CreateObjectSet<tb_defdefault>("tb_defdefault");
                }
                return _tb_defdefault;
            }
        }
        private ObjectSet<tb_defdefault> _tb_defdefault;

        #endregion

        #region Métodos AddTo
    
        /// <summary>
        /// Método preterido para adicionar um novo objeto ao EntitySet potencias. Em vez disso, experimente usar o método .Add da propriedade ObjectSet&lt;T&gt; associada.
        /// </summary>
        public void AddTopotencias(potencia potencia)
        {
            base.AddObject("potencias", potencia);
        }
    
        /// <summary>
        /// Método preterido para adicionar um novo objeto ao EntitySet tb_alimentos. Em vez disso, experimente usar o método .Add da propriedade ObjectSet&lt;T&gt; associada.
        /// </summary>
        public void AddTotb_alimentos(tb_alimentos tb_alimentos)
        {
            base.AddObject("tb_alimentos", tb_alimentos);
        }
    
        /// <summary>
        /// Método preterido para adicionar um novo objeto ao EntitySet tb_defdefault. Em vez disso, experimente usar o método .Add da propriedade ObjectSet&lt;T&gt; associada.
        /// </summary>
        public void AddTotb_defdefault(tb_defdefault tb_defdefault)
        {
            base.AddObject("tb_defdefault", tb_defdefault);
        }

        #endregion

    }

    #endregion

    #region Entidades
    
    /// <summary>
    /// Nenhuma Documentação de Metadados disponível.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="db_microondasModel", Name="potencia")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class potencia : EntityObject
    {
        #region Método de Fábrica
    
        /// <summary>
        /// Crie um novo objeto potencia.
        /// </summary>
        /// <param name="idpotencia">Valor inicial da propriedade idpotencia.</param>
        /// <param name="valor_potencia">Valor inicial da propriedade valor_potencia.</param>
        public static potencia Createpotencia(global::System.Int32 idpotencia, global::System.Int32 valor_potencia)
        {
            potencia potencia = new potencia();
            potencia.idpotencia = idpotencia;
            potencia.valor_potencia = valor_potencia;
            return potencia;
        }

        #endregion

        #region Propriedades Simples
    
        /// <summary>
        /// Nenhuma Documentação de Metadados disponível.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 idpotencia
        {
            get
            {
                return _idpotencia;
            }
            set
            {
                if (_idpotencia != value)
                {
                    OnidpotenciaChanging(value);
                    ReportPropertyChanging("idpotencia");
                    _idpotencia = StructuralObject.SetValidValue(value, "idpotencia");
                    ReportPropertyChanged("idpotencia");
                    OnidpotenciaChanged();
                }
            }
        }
        private global::System.Int32 _idpotencia;
        partial void OnidpotenciaChanging(global::System.Int32 value);
        partial void OnidpotenciaChanged();
    
        /// <summary>
        /// Nenhuma Documentação de Metadados disponível.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 valor_potencia
        {
            get
            {
                return _valor_potencia;
            }
            set
            {
                Onvalor_potenciaChanging(value);
                ReportPropertyChanging("valor_potencia");
                _valor_potencia = StructuralObject.SetValidValue(value, "valor_potencia");
                ReportPropertyChanged("valor_potencia");
                Onvalor_potenciaChanged();
            }
        }
        private global::System.Int32 _valor_potencia;
        partial void Onvalor_potenciaChanging(global::System.Int32 value);
        partial void Onvalor_potenciaChanged();

        #endregion

        #region Propriedades de Navegação
    
        /// <summary>
        /// Nenhuma Documentação de Metadados disponível.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("db_microondasModel", "fk_tb_defdefault_potencia1", "tb_defdefault")]
        public EntityCollection<tb_defdefault> tb_defdefault
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<tb_defdefault>("db_microondasModel.fk_tb_defdefault_potencia1", "tb_defdefault");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<tb_defdefault>("db_microondasModel.fk_tb_defdefault_potencia1", "tb_defdefault", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// Nenhuma Documentação de Metadados disponível.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="db_microondasModel", Name="tb_alimentos")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class tb_alimentos : EntityObject
    {
        #region Método de Fábrica
    
        /// <summary>
        /// Crie um novo objeto tb_alimentos.
        /// </summary>
        /// <param name="id_alimentos">Valor inicial da propriedade id_alimentos.</param>
        /// <param name="descricao_alimento">Valor inicial da propriedade descricao_alimento.</param>
        public static tb_alimentos Createtb_alimentos(global::System.Int32 id_alimentos, global::System.String descricao_alimento)
        {
            tb_alimentos tb_alimentos = new tb_alimentos();
            tb_alimentos.id_alimentos = id_alimentos;
            tb_alimentos.descricao_alimento = descricao_alimento;
            return tb_alimentos;
        }

        #endregion

        #region Propriedades Simples
    
        /// <summary>
        /// Nenhuma Documentação de Metadados disponível.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id_alimentos
        {
            get
            {
                return _id_alimentos;
            }
            set
            {
                if (_id_alimentos != value)
                {
                    Onid_alimentosChanging(value);
                    ReportPropertyChanging("id_alimentos");
                    _id_alimentos = StructuralObject.SetValidValue(value, "id_alimentos");
                    ReportPropertyChanged("id_alimentos");
                    Onid_alimentosChanged();
                }
            }
        }
        private global::System.Int32 _id_alimentos;
        partial void Onid_alimentosChanging(global::System.Int32 value);
        partial void Onid_alimentosChanged();
    
        /// <summary>
        /// Nenhuma Documentação de Metadados disponível.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String descricao_alimento
        {
            get
            {
                return _descricao_alimento;
            }
            set
            {
                Ondescricao_alimentoChanging(value);
                ReportPropertyChanging("descricao_alimento");
                _descricao_alimento = StructuralObject.SetValidValue(value, false, "descricao_alimento");
                ReportPropertyChanged("descricao_alimento");
                Ondescricao_alimentoChanged();
            }
        }
        private global::System.String _descricao_alimento;
        partial void Ondescricao_alimentoChanging(global::System.String value);
        partial void Ondescricao_alimentoChanged();
    
        /// <summary>
        /// Nenhuma Documentação de Metadados disponível.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> id_defdefault
        {
            get
            {
                return _id_defdefault;
            }
            set
            {
                Onid_defdefaultChanging(value);
                ReportPropertyChanging("id_defdefault");
                _id_defdefault = StructuralObject.SetValidValue(value, "id_defdefault");
                ReportPropertyChanged("id_defdefault");
                Onid_defdefaultChanged();
            }
        }
        private Nullable<global::System.Int32> _id_defdefault;
        partial void Onid_defdefaultChanging(Nullable<global::System.Int32> value);
        partial void Onid_defdefaultChanged();

        #endregion

        #region Propriedades de Navegação
    
        /// <summary>
        /// Nenhuma Documentação de Metadados disponível.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("db_microondasModel", "fk_tb_alimentos_tb_defdefault", "tb_defdefault")]
        public tb_defdefault tb_defdefault
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<tb_defdefault>("db_microondasModel.fk_tb_alimentos_tb_defdefault", "tb_defdefault").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<tb_defdefault>("db_microondasModel.fk_tb_alimentos_tb_defdefault", "tb_defdefault").Value = value;
            }
        }
        /// <summary>
        /// Nenhuma Documentação de Metadados disponível.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<tb_defdefault> tb_defdefaultReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<tb_defdefault>("db_microondasModel.fk_tb_alimentos_tb_defdefault", "tb_defdefault");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<tb_defdefault>("db_microondasModel.fk_tb_alimentos_tb_defdefault", "tb_defdefault", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// Nenhuma Documentação de Metadados disponível.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="db_microondasModel", Name="tb_defdefault")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class tb_defdefault : EntityObject
    {
        #region Método de Fábrica
    
        /// <summary>
        /// Crie um novo objeto tb_defdefault.
        /// </summary>
        /// <param name="id_defdefault">Valor inicial da propriedade id_defdefault.</param>
        /// <param name="tempo_defaut">Valor inicial da propriedade tempo_defaut.</param>
        /// <param name="idpotencia">Valor inicial da propriedade idpotencia.</param>
        public static tb_defdefault Createtb_defdefault(global::System.Int32 id_defdefault, global::System.Int32 tempo_defaut, global::System.Int32 idpotencia)
        {
            tb_defdefault tb_defdefault = new tb_defdefault();
            tb_defdefault.id_defdefault = id_defdefault;
            tb_defdefault.tempo_defaut = tempo_defaut;
            tb_defdefault.idpotencia = idpotencia;
            return tb_defdefault;
        }

        #endregion

        #region Propriedades Simples
    
        /// <summary>
        /// Nenhuma Documentação de Metadados disponível.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id_defdefault
        {
            get
            {
                return _id_defdefault;
            }
            set
            {
                if (_id_defdefault != value)
                {
                    Onid_defdefaultChanging(value);
                    ReportPropertyChanging("id_defdefault");
                    _id_defdefault = StructuralObject.SetValidValue(value, "id_defdefault");
                    ReportPropertyChanged("id_defdefault");
                    Onid_defdefaultChanged();
                }
            }
        }
        private global::System.Int32 _id_defdefault;
        partial void Onid_defdefaultChanging(global::System.Int32 value);
        partial void Onid_defdefaultChanged();
    
        /// <summary>
        /// Nenhuma Documentação de Metadados disponível.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 tempo_defaut
        {
            get
            {
                return _tempo_defaut;
            }
            set
            {
                Ontempo_defautChanging(value);
                ReportPropertyChanging("tempo_defaut");
                _tempo_defaut = StructuralObject.SetValidValue(value, "tempo_defaut");
                ReportPropertyChanged("tempo_defaut");
                Ontempo_defautChanged();
            }
        }
        private global::System.Int32 _tempo_defaut;
        partial void Ontempo_defautChanging(global::System.Int32 value);
        partial void Ontempo_defautChanged();
    
        /// <summary>
        /// Nenhuma Documentação de Metadados disponível.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 idpotencia
        {
            get
            {
                return _idpotencia;
            }
            set
            {
                OnidpotenciaChanging(value);
                ReportPropertyChanging("idpotencia");
                _idpotencia = StructuralObject.SetValidValue(value, "idpotencia");
                ReportPropertyChanged("idpotencia");
                OnidpotenciaChanged();
            }
        }
        private global::System.Int32 _idpotencia;
        partial void OnidpotenciaChanging(global::System.Int32 value);
        partial void OnidpotenciaChanged();

        #endregion

        #region Propriedades de Navegação
    
        /// <summary>
        /// Nenhuma Documentação de Metadados disponível.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("db_microondasModel", "fk_tb_defdefault_potencia1", "potencia")]
        public potencia potencia
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<potencia>("db_microondasModel.fk_tb_defdefault_potencia1", "potencia").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<potencia>("db_microondasModel.fk_tb_defdefault_potencia1", "potencia").Value = value;
            }
        }
        /// <summary>
        /// Nenhuma Documentação de Metadados disponível.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<potencia> potenciaReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<potencia>("db_microondasModel.fk_tb_defdefault_potencia1", "potencia");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<potencia>("db_microondasModel.fk_tb_defdefault_potencia1", "potencia", value);
                }
            }
        }
    
        /// <summary>
        /// Nenhuma Documentação de Metadados disponível.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("db_microondasModel", "fk_tb_alimentos_tb_defdefault", "tb_alimentos")]
        public EntityCollection<tb_alimentos> tb_alimentos
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<tb_alimentos>("db_microondasModel.fk_tb_alimentos_tb_defdefault", "tb_alimentos");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<tb_alimentos>("db_microondasModel.fk_tb_alimentos_tb_defdefault", "tb_alimentos", value);
                }
            }
        }

        #endregion

    }

    #endregion

}
