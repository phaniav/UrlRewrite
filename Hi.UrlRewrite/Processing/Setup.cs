﻿using System;
using Hi.UrlRewrite.Templates.Settings;
using Sitecore;
using Sitecore.Configuration;
using Sitecore.Data;
using Sitecore.Publishing;
using Sitecore.SecurityModel;
using System.Linq;

namespace Hi.UrlRewrite.Processing
{
    public class Setup
    {
        public void InstallItems()
        {
            try
            {
                //if (!Factory.GetDatabaseNames().Any(e => e.Equals("master"))) return;

                //var settingsDb = Factory.GetDatabase("master");
                //if (settingsDb == null) return;

                //using (new SecurityDisabler())
                //{
                //    var settingsItem = settingsDb.GetItem(new ID(Constants.UrlRewriteSettings_ItemId));
                //    if (settingsItem == null) return;

                //    var settings = new SettingsItem(settingsItem);
                //    var publishingTargets = settings.InstallationPublishingTargets.GetItems();
                //    var dbArray = publishingTargets.Select(x => Factory.GetDatabase(x.Fields["Target database"].Value)).ToArray();

                //    // install templates
                //    var urlRewriteTemplatesFolderItem = settingsDb.GetItem(new ID(Constants.UrlRewriteTemplatesFolder_ItemId));
                //    if (urlRewriteTemplatesFolderItem != null)
                //    {
                //        PublishManager.PublishItem(urlRewriteTemplatesFolderItem, dbArray, urlRewriteTemplatesFolderItem.Languages, true,
                //            true);
                //    }
                //}
            }
            catch (Exception)
            {
                Log.Debug(this, "Unable to run installation.");
            }
        }
    }
}