//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WixToolset.Extensions
{
    using System;
    using System.Reflection;
    using System.Resources;
    using WixToolset.Data;
    
    
    public class IIsErrorEventArgs : MessageEventArgs
    {
        
        private static ResourceManager resourceManager = new ResourceManager("WixToolset.Extensions.Data.Messages", Assembly.GetExecutingAssembly());
        
        public IIsErrorEventArgs(SourceLineNumber sourceLineNumbers, int id, string resourceName, params object[] messageArgs) : 
                base(sourceLineNumbers, id, resourceName, messageArgs)
        {
            base.ResourceManager = resourceManager;
        }
    }
    
    public sealed class IIsErrors
    {
        
        private IIsErrors()
        {
        }
        
        public static MessageEventArgs MimeMapExtensionMissingPeriod(SourceLineNumber sourceLineNumbers, string elementName, string attributeName, string attributeValue)
        {
            return new IIsErrorEventArgs(sourceLineNumbers, 5150, "IIsErrors_MimeMapExtensionMissingPeriod_1", elementName, attributeName, attributeValue);
        }
        
        public static MessageEventArgs IllegalAttributeWithoutComponent(SourceLineNumber sourceLineNumbers, string elementName, string attributeName)
        {
            return new IIsErrorEventArgs(sourceLineNumbers, 5151, "IIsErrors_IllegalAttributeWithoutComponent_1", elementName, attributeName);
        }
        
        public static MessageEventArgs IllegalElementWithoutComponent(SourceLineNumber sourceLineNumbers, string elementName)
        {
            return new IIsErrorEventArgs(sourceLineNumbers, 5152, "IIsErrors_IllegalElementWithoutComponent_1", elementName);
        }
        
        public static MessageEventArgs OneOfAttributesRequiredUnderComponent(SourceLineNumber sourceLineNumbers, string elementName, string attributeName1, string attributeName2, string attributeName3, string attributeName4)
        {
            return new IIsErrorEventArgs(sourceLineNumbers, 5153, "IIsErrors_OneOfAttributesRequiredUnderComponent_1", elementName, attributeName1, attributeName2, attributeName3, attributeName4);
        }
        
        public static MessageEventArgs WebSiteAttributeUnderWebSite(SourceLineNumber sourceLineNumbers, string elementName)
        {
            return new IIsErrorEventArgs(sourceLineNumbers, 5154, "IIsErrors_WebSiteAttributeUnderWebSite_1", elementName);
        }
        
        public static MessageEventArgs WebApplicationAlreadySpecified(SourceLineNumber sourceLineNumbers, string elementName)
        {
            return new IIsErrorEventArgs(sourceLineNumbers, 5155, "IIsErrors_WebApplicationAlreadySpecified_1", elementName);
        }
        
        public static MessageEventArgs IllegalCharacterInAttributeValue(SourceLineNumber sourceLineNumbers, string elementName, string attributeName, string value, char illegalCharacter)
        {
            return new IIsErrorEventArgs(sourceLineNumbers, 5156, "IIsErrors_IllegalCharacterInAttributeValue_1", elementName, attributeName, value, illegalCharacter);
        }
        
        public static MessageEventArgs DeprecatedBinaryChildElement(SourceLineNumber sourceLineNumbers, string elementName)
        {
            return new IIsErrorEventArgs(sourceLineNumbers, 5157, "IIsErrors_DeprecatedBinaryChildElement_1", elementName);
        }
        
        public static MessageEventArgs WebSiteNotFound(string webSiteDescription)
        {
            return new IIsErrorEventArgs(null, 5158, "IIsErrors_WebSiteNotFound_1", webSiteDescription);
        }
        
        public static MessageEventArgs InsufficientPermissionHarvestWebSite()
        {
            return new IIsErrorEventArgs(null, 5159, "IIsErrors_InsufficientPermissionHarvestWebSite_1");
        }
        
        public static MessageEventArgs CannotHarvestWebSite()
        {
            return new IIsErrorEventArgs(null, 5160, "IIsErrors_CannotHarvestWebSite_1");
        }
        
        public static MessageEventArgs RequiredAttributeUnderComponent(SourceLineNumber sourceLineNumbers, string elementName, string attributeName)
        {
            return new IIsErrorEventArgs(sourceLineNumbers, 5161, "IIsErrors_RequiredAttributeUnderComponent_1", elementName, attributeName);
        }
    }
    
    public class IIsWarningEventArgs : MessageEventArgs
    {
        
        private static ResourceManager resourceManager = new ResourceManager("WixToolset.Extensions.Data.Messages", Assembly.GetExecutingAssembly());
        
        public IIsWarningEventArgs(SourceLineNumber sourceLineNumbers, int id, string resourceName, params object[] messageArgs) : 
                base(sourceLineNumbers, id, resourceName, messageArgs)
        {
            base.ResourceManager = resourceManager;
        }
    }
    
    public sealed class IIsWarnings
    {
        
        private IIsWarnings()
        {
        }
        
        public static MessageEventArgs EncounteredNullDirectoryForWebSite(string directory)
        {
            return new IIsWarningEventArgs(null, 5400, "IIsWarnings_EncounteredNullDirectoryForWebSite_1", directory);
        }
    }
    
    public class IIsVerboseEventArgs : MessageEventArgs
    {
        
        private static ResourceManager resourceManager = new ResourceManager("WixToolset.Extensions.Data.Messages", Assembly.GetExecutingAssembly());
        
        public IIsVerboseEventArgs(SourceLineNumber sourceLineNumbers, int id, string resourceName, params object[] messageArgs) : 
                base(sourceLineNumbers, id, resourceName, messageArgs)
        {
            base.ResourceManager = resourceManager;
        }
    }
    
    public sealed class IIsVerboses
    {
        
        private IIsVerboses()
        {
        }
    }
}

/*
<?xml version='1.0' encoding='utf-8'?>
<!-- Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information. -->


<Messages Namespace="WixToolset.Extensions" Resources="Data.Messages" xmlns="http://schemas.microsoft.com/genmsgs/2004/07/messages">
    <Class Name="IIsErrors" ContainerName="IIsErrorEventArgs" BaseContainerName="MessageEventArgs">
        <Message Id="MimeMapExtensionMissingPeriod" Number="5150">
            <Instance>The {0}/@{1} attribute's value, '{2}', is not a valid mime map extension.  It must begin with a period.
                <Parameter Type="System.String" Name="elementName" />
                <Parameter Type="System.String" Name="attributeName" />
                <Parameter Type="System.String" Name="attributeValue" />
            </Instance>
        </Message>
        <Message Id="IllegalAttributeWithoutComponent" Number="5151">
            <Instance>The {0}/@{1} attribute cannot be specified unless the element has a Component as an ancestor. A {0} that does not have a Component ancestor is not installed.
                <Parameter Type="System.String" Name="elementName" />
                <Parameter Type="System.String" Name="attributeName" />
            </Instance>
        </Message>
        <Message Id="IllegalElementWithoutComponent" Number="5152">
            <Instance>The {0} element cannot be specified unless the element has a Component as an ancestor. A {0} that does not have a Component ancestor is not installed.
                <Parameter Type="System.String" Name="elementName" />
            </Instance>
        </Message>
        <Message Id="OneOfAttributesRequiredUnderComponent" Number="5153">
            <Instance>When nested under a Component, the {0} element must have one of the following attributes specified: {1}, {2}, {3} or {4}.
                <Parameter Type="System.String" Name="elementName" />
                <Parameter Type="System.String" Name="attributeName1" />
                <Parameter Type="System.String" Name="attributeName2" />
                <Parameter Type="System.String" Name="attributeName3" />
                <Parameter Type="System.String" Name="attributeName4" />
            </Instance>
        </Message>
        <Message Id="WebSiteAttributeUnderWebSite" Number="5154">
            <Instance>The {0}/@WebSite attribute cannot be specified when the {0} element is nested under a WebSite element.
                <Parameter Type="System.String" Name="elementName" />
            </Instance>
        </Message>
        <Message Id="WebApplicationAlreadySpecified" Number="5155">
            <Instance>The {0} element can have at most a single WebApplication specified. This can be either through the WebApplication attribute, or through a nested WebApplication element, but not both.
                <Parameter Type="System.String" Name="elementName" />
            </Instance>
        </Message>
        <Message Id="IllegalCharacterInAttributeValue" Number="5156">
            <Instance>
                The {0}/@{1} attribute's value, '{2}', is invalid.  It cannot contain the character '{3}'.
                <Parameter Type="System.String" Name="elementName" />
                <Parameter Type="System.String" Name="attributeName" />
                <Parameter Type="System.String" Name="value" />
                <Parameter Type="System.Char" Name="illegalCharacter" />
            </Instance>
        </Message>
        <Message Id="DeprecatedBinaryChildElement" Number="5157">
            <Instance>The {0} element contains a deprecated child Binary element.  Please move the Binary element under a Fragment, Module, or Product element and set the {0}/@BinaryKey attribute to the value of the Binary/@Id attribute.
                <Parameter Type="System.String" Name="elementName" />
            </Instance>
        </Message>
        <Message Id="WebSiteNotFound" Number="5158" SourceLineNumbers="no">
            <Instance>
                The web site '{0}' could not be found.  Please check that the web site exists, and that it is spelled correctly (please note, you must use the correct case).
                <Parameter Type="System.String" Name="webSiteDescription" />
            </Instance>
        </Message>
        <Message Id="InsufficientPermissionHarvestWebSite" Number="5159" SourceLineNumbers="no">
            <Instance>
                Not enough permissions to harvest website. On Windows Vista, you must run Heat elevated.
            </Instance>
        </Message>
        <Message Id="CannotHarvestWebSite" Number="5160" SourceLineNumbers="no">
            <Instance>
                Cannot harvest website. On Windows Vista, you must install IIS 6 Management Compatibility.
            </Instance>
        </Message>
        <Message Id="RequiredAttributeUnderComponent" Number="5161">
            <Instance>The {0}/@{1} attribute must be specified when the element has a Component as an ancestor.
                <Parameter Type="System.String" Name="elementName" />
                <Parameter Type="System.String" Name="attributeName" />
            </Instance>
        </Message>
    </Class>
    <Class Name="IIsWarnings" ContainerName="IIsWarningEventArgs" BaseContainerName="MessageEventArgs">
      <Message Id="EncounteredNullDirectoryForWebSite" Number="5400" SourceLineNumbers="no">
        <Instance>
          Could not harvest website directory: {0}.  Please update the output with the appropriate directory ID before using.
          <Parameter Type="System.String" Name="directory" />
        </Instance>
      </Message>
    </Class>
    <Class Name="IIsVerboses" ContainerName="IIsVerboseEventArgs" BaseContainerName="MessageEventArgs">
    </Class>
</Messages>
*/