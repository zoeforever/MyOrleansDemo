// <auto-generated />
#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 414
#pragma warning disable 618
#pragma warning disable 649
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998
[assembly: global::Orleans.Metadata.FeaturePopulatorAttribute(typeof(OrleansGeneratedCode.OrleansCodeGen00c83b4ddbFeaturePopulator))]
[assembly: global::System.CodeDom.Compiler.GeneratedCodeAttribute(@"Orleans-CodeGenerator", @"2.0.0.0")]
[assembly: global::Orleans.CodeGeneration.OrleansCodeGenerationTargetAttribute(@"ShoppingRecordServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")]
namespace OrleansGeneratedCode9189F7EF
{
    using global::Orleans;
    using global::System.Reflection;
}

namespace OrleansGeneratedCode
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute(@"Orleans-CodeGenerator", @"2.0.0.0")]
    internal sealed class OrleansCodeGen00c83b4ddbFeaturePopulator : global::Orleans.Metadata.IFeaturePopulator<global::Orleans.Metadata.GrainInterfaceFeature>, global::Orleans.Metadata.IFeaturePopulator<global::Orleans.Metadata.GrainClassFeature>, global::Orleans.Metadata.IFeaturePopulator<global::Orleans.Serialization.SerializerFeature>
    {
        public void Populate(global::Orleans.Metadata.GrainInterfaceFeature feature)
        {
        }

        public void Populate(global::Orleans.Metadata.GrainClassFeature feature)
        {
            feature.Classes.Add(new global::Orleans.Metadata.GrainClassMetadata(typeof(global::ShoppingRecordServer.ShoppingRecordServer)));
        }

        public void Populate(global::Orleans.Serialization.SerializerFeature feature)
        {
            feature.AddKnownType(@"ShoppingRecordServer.ShoppingRecordServer,ShoppingRecordServer", @"ShoppingRecordServer.ShoppingRecordServer");
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 649
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif
