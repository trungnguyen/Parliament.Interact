// <auto-generated />
namespace Parliament.Interact.Core.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.1.3-40302")]
    public sealed partial class addedforeignkeyrelationshipbetweenissueandactionItem : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(addedforeignkeyrelationshipbetweenissueandactionItem));
        
        string IMigrationMetadata.Id
        {
            get { return "201603221523569_added foreign key relationship between issue and actionItem"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}
