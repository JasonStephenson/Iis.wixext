// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.Iis
{
    using WixToolset.Data;
    using WixToolset.Iis.Tuples;

    public static partial class IisTupleDefinitions
    {
        public static readonly IntermediateTupleDefinition Certificate = new IntermediateTupleDefinition(
            IisTupleDefinitionType.Certificate.ToString(),
            new[]
            {
                new IntermediateFieldDefinition(nameof(CertificateTupleFields.Certificate), IntermediateFieldType.String),
                new IntermediateFieldDefinition(nameof(CertificateTupleFields.Component_), IntermediateFieldType.String),
                new IntermediateFieldDefinition(nameof(CertificateTupleFields.Name), IntermediateFieldType.String),
                new IntermediateFieldDefinition(nameof(CertificateTupleFields.StoreLocation), IntermediateFieldType.Number),
                new IntermediateFieldDefinition(nameof(CertificateTupleFields.StoreName), IntermediateFieldType.String),
                new IntermediateFieldDefinition(nameof(CertificateTupleFields.Attributes), IntermediateFieldType.Number),
                new IntermediateFieldDefinition(nameof(CertificateTupleFields.Binary_), IntermediateFieldType.String),
                new IntermediateFieldDefinition(nameof(CertificateTupleFields.CertificatePath), IntermediateFieldType.String),
                new IntermediateFieldDefinition(nameof(CertificateTupleFields.PFXPassword), IntermediateFieldType.String),
            },
            typeof(CertificateTuple));
    }
}

namespace WixToolset.Iis.Tuples
{
    using WixToolset.Data;

    public enum CertificateTupleFields
    {
        Certificate,
        Component_,
        Name,
        StoreLocation,
        StoreName,
        Attributes,
        Binary_,
        CertificatePath,
        PFXPassword,
    }

    public class CertificateTuple : IntermediateTuple
    {
        public CertificateTuple() : base(IisTupleDefinitions.Certificate, null, null)
        {
        }

        public CertificateTuple(SourceLineNumber sourceLineNumber, Identifier id = null) : base(IisTupleDefinitions.Certificate, sourceLineNumber, id)
        {
        }

        public IntermediateField this[CertificateTupleFields index] => this.Fields[(int)index];

        public string Certificate
        {
            get => this.Fields[(int)CertificateTupleFields.Certificate].AsString();
            set => this.Set((int)CertificateTupleFields.Certificate, value);
        }

        public string Component_
        {
            get => this.Fields[(int)CertificateTupleFields.Component_].AsString();
            set => this.Set((int)CertificateTupleFields.Component_, value);
        }

        public string Name
        {
            get => this.Fields[(int)CertificateTupleFields.Name].AsString();
            set => this.Set((int)CertificateTupleFields.Name, value);
        }

        public int StoreLocation
        {
            get => this.Fields[(int)CertificateTupleFields.StoreLocation].AsNumber();
            set => this.Set((int)CertificateTupleFields.StoreLocation, value);
        }

        public string StoreName
        {
            get => this.Fields[(int)CertificateTupleFields.StoreName].AsString();
            set => this.Set((int)CertificateTupleFields.StoreName, value);
        }

        public int Attributes
        {
            get => this.Fields[(int)CertificateTupleFields.Attributes].AsNumber();
            set => this.Set((int)CertificateTupleFields.Attributes, value);
        }

        public string Binary_
        {
            get => this.Fields[(int)CertificateTupleFields.Binary_].AsString();
            set => this.Set((int)CertificateTupleFields.Binary_, value);
        }

        public string CertificatePath
        {
            get => this.Fields[(int)CertificateTupleFields.CertificatePath].AsString();
            set => this.Set((int)CertificateTupleFields.CertificatePath, value);
        }

        public string PFXPassword
        {
            get => this.Fields[(int)CertificateTupleFields.PFXPassword].AsString();
            set => this.Set((int)CertificateTupleFields.PFXPassword, value);
        }
    }
}