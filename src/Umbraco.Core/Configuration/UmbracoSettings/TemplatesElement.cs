﻿using System.Configuration;

namespace Umbraco.Core.Configuration.UmbracoSettings
{
    internal class TemplatesElement : ConfigurationElement
    {
        [ConfigurationProperty("useAspNetMasterPages")]
        internal InnerTextConfigurationElement<bool> UseAspNetMasterPages
        {
            get
            {
                return new OptionalInnerTextConfigurationElement<bool>(
                    (InnerTextConfigurationElement<bool>)this["useAspNetMasterPages"],
                    //set the default
                    true);
            }
        }

        [ConfigurationProperty("enableSkinSupport")]
        internal InnerTextConfigurationElement<bool> EnableSkinSupport
        {
            get
            {
                return new OptionalInnerTextConfigurationElement<bool>(
                    (InnerTextConfigurationElement<bool>)this["enableSkinSupport"],
                    //set the default
                    true);
            }
        }

        [ConfigurationProperty("defaultRenderingEngine", IsRequired = true)]
        internal InnerTextConfigurationElement<RenderingEngine> DefaultRenderingEngine
        {
            get
            {
                return new OptionalInnerTextConfigurationElement<RenderingEngine>(
                    (InnerTextConfigurationElement<RenderingEngine>)this["defaultRenderingEngine"],
                    //set the default
                    RenderingEngine.Mvc);
            }
        }

        [ConfigurationProperty("enableTemplateFolders")]
        internal InnerTextConfigurationElement<bool> EnableTemplateFolders
        {
            get
            {
                return new OptionalInnerTextConfigurationElement<bool>(
                    (InnerTextConfigurationElement<bool>)this["enableTemplateFolders"],
                    //set the default
                    false);
            }
        }
    }
}