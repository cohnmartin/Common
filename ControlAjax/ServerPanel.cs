﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using AjaxControlToolkit;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Script.Serialization;



[assembly: WebResource("ControlsAjaxNotti.ClientServerPanel.js", "application/x-javascript")]
[assembly: WebResource("ControlsAjaxNotti.jquery-1.3.2.min.js", "application/x-javascript")]


namespace ControlsAjaxNotti
{
    [ParseChildren(true)]
    public class ServerPanel : ScriptControlBase, INamingContainer
    {
        public ServerPanel()
            : base(false, HtmlTextWriterTag.Div)
        {
            //
            // TODO: Add constructor logic here
            //
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            InitialiseControls();
            


        }

        protected override void OnPreRender(EventArgs e)
        {

            base.OnPreRender(e);
        }

        private void InitialiseControls()
        {

            //<div class="dialog">
            //    <div class="content">
            //        <div class="t">
            //        </div>
            //        <div class="hd">
            //        </div>
            //        <div class="bd">
            //            </div>
            //    </div>
            //    <div class="b">
            //      <div></div>
            //    </div>
            //</div>


            //HtmlGenericControl divDialog = new HtmlGenericControl("div");
            //divDialog.ID = "_divDialog";
            //divDialog.Attributes.Add("class", "dialog");
            //this.Controls.Add(divDialog);


            //HtmlGenericControl divContent = new HtmlGenericControl("div");
            //divContent.ID = "_divContent";
            //divContent.Style.Value = "background:transparent url(" + Page.ClientScript.GetWebResourceUrl(this.GetType(), "ControlsAjaxNotti.WindowStatic.dialog2-blue-800x1600.png") + ") no-repeat right top";
            //divContent.Attributes.Add("class", "content");
            //divDialog.Controls.Add(divContent);



            //HtmlGenericControl divt = new HtmlGenericControl("div");
            //divt.ID = "_divt";
            //divt.Style.Value = "background:transparent url(" + Page.ClientScript.GetWebResourceUrl(this.GetType(), "ControlsAjaxNotti.WindowStatic.dialog2-blue-800x1600.png") + ") no-repeat top left";
            //divt.Attributes.Add("class", "t");
            //divContent.Controls.Add(divt);


            //HtmlGenericControl divHeader = new HtmlGenericControl("div");
            //divHeader.ID = "_divHeader";
            //divHeader.Attributes.Add("class", "hd");
            //divContent.Controls.Add(divHeader);


            //HtmlGenericControl TituloHeader = new HtmlGenericControl("h2");
            //TituloHeader.ID = "_TituloHeader";
            //divHeader.Controls.Add(TituloHeader);



            //HtmlGenericControl divBody = new HtmlGenericControl("div");
            //divBody.ID = "_divBody";
            //divBody.Attributes.Add("class", "bd");
            //divContent.Controls.Add(divBody);


            //HtmlGenericControl divb = new HtmlGenericControl("div");
            //divb.ID = "_divb";
            //divb.Style.Value = "background :transparent url(" + Page.ClientScript.GetWebResourceUrl(this.GetType(), "ControlsAjaxNotti.WindowStatic.dialog2-blue-800x1600.png") + ") no-repeat bottom right";
            //divb.Attributes.Add("class", "b");
            //divDialog.Controls.Add(divb);

            //HtmlGenericControl divVacio = new HtmlGenericControl("div");
            //divVacio.ID = "_divVacio";
            //divVacio.Style.Value = "background:transparent url(" + Page.ClientScript.GetWebResourceUrl(this.GetType(), "ControlsAjaxNotti.WindowStatic.dialog2-blue-800x1600.png") + ") no-repeat bottom left";
            //divVacio.InnerHtml = "&nbsp;";
            //divb.Controls.Add(divVacio);

            this.Controls.Clear();
            this.Controls.Add(BodyContent);

            //BodyContent.InstantiateIn(this);

            //this.Controls.Add(divDialog);
        }


        [PersistenceMode(PersistenceMode.InnerProperty), TemplateContainer(typeof(TemplateControl)), TemplateInstance(TemplateInstance.Single)]
        public PlaceHolder BodyContent
        {
            get;
            set;
        }

      

        protected override IEnumerable<ScriptDescriptor>
                GetScriptDescriptors()
        {
            ScriptControlDescriptor descriptor = new ScriptControlDescriptor("ControlsAjaxNotti.ClientServerPanel", this.ClientID);
            yield return descriptor;
        }

        // Generate the script reference
        protected override IEnumerable<ScriptReference>
                GetScriptReferences()
        {
            List<ScriptReference> js = new List<ScriptReference>();
            js.Add(new ScriptReference("ControlsAjaxNotti.ClientServerPanel.js", this.GetType().Assembly.FullName));
            //js.Add(new ScriptReference("ControlsAjaxNotti.jquery-1.3.2.min.js", this.GetType().Assembly.FullName));
            return js;

        }
    }
}
