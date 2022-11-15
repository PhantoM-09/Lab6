using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TelephoneDirectory.Helpers
{
    public static class FormHelper
    {
        public static MvcHtmlString CreateAddForm(this HtmlHelper html)
        {
            TagBuilder form = new TagBuilder("form");
            Dictionary<string, string> formAttributes = new Dictionary<string, string>();
            formAttributes.Add("method", "post");
            formAttributes.Add("action", "/Dict/AddSave/");
            form.MergeAttributes(formAttributes);

            TagBuilder inputId = new TagBuilder("input");
            Dictionary<string, string> idAttributes = new Dictionary<string, string>();
            idAttributes.Add("type", "hidden");
            idAttributes.Add("value", "0");
            idAttributes.Add("name", "Id");
            inputId.MergeAttributes(idAttributes);

            TagBuilder labelLastName = new TagBuilder("label");
            labelLastName.InnerHtml = "Фамилия: ";

            TagBuilder inputLastName = new TagBuilder("input");
            Dictionary<string, string> lastNameAttributes = new Dictionary<string, string>();
            lastNameAttributes.Add("type", "text");
            lastNameAttributes.Add("name", "LastName");
            inputLastName.MergeAttributes(lastNameAttributes);

            TagBuilder labelPhoneNumber = new TagBuilder("label");
            labelPhoneNumber.InnerHtml = "Номер телефона: ";

            TagBuilder inputPhoneNumber = new TagBuilder("input");
            Dictionary<string, string> phoneNumberAttributes = new Dictionary<string, string>();
            phoneNumberAttributes.Add("type", "text");
            phoneNumberAttributes.Add("name", "PhoneNumber");
            inputPhoneNumber.MergeAttributes(phoneNumberAttributes);

            TagBuilder inputSubmit = new TagBuilder("input");
            Dictionary<string, string> submitAttributes = new Dictionary<string, string>();
            submitAttributes.Add("type", "submit");
            submitAttributes.Add("value", "Добавить");
            inputSubmit.MergeAttributes(submitAttributes);

            form.InnerHtml += inputId.ToString();
            form.InnerHtml += labelLastName.ToString();
            form.InnerHtml += inputLastName.ToString();
            form.InnerHtml += labelPhoneNumber.ToString();
            form.InnerHtml += inputPhoneNumber.ToString();
            form.InnerHtml += inputSubmit.ToString();
            
            return MvcHtmlString.Create(form.ToString());
        }

        public static MvcHtmlString CreateUpdateForm(this HtmlHelper html, PhoneRecord phoneRecord)
        {
            TagBuilder form = new TagBuilder("form");
            Dictionary<string, string> formAttributes = new Dictionary<string, string>();
            formAttributes.Add("method", "post");
            formAttributes.Add("action", "/Dict/UpdateSave/");
            form.MergeAttributes(formAttributes);

            TagBuilder inputId = new TagBuilder("input");
            Dictionary<string, string> idAttributes = new Dictionary<string, string>();
            idAttributes.Add("type", "hidden");
            idAttributes.Add("value", phoneRecord.Id.ToString());
            idAttributes.Add("name", "Id");
            inputId.MergeAttributes(idAttributes);

            TagBuilder labelLastName = new TagBuilder("label");
            labelLastName.InnerHtml = "Фамилия: ";

            TagBuilder inputLastName = new TagBuilder("input");
            Dictionary<string, string> lastNameAttributes = new Dictionary<string, string>();
            lastNameAttributes.Add("type", "text");
            lastNameAttributes.Add("name", "LastName");
            lastNameAttributes.Add("value", phoneRecord.LastName);
            inputLastName.MergeAttributes(lastNameAttributes);

            TagBuilder labelPhoneNumber = new TagBuilder("label");
            labelPhoneNumber.InnerHtml = "Номер телефона: ";

            TagBuilder inputPhoneNumber = new TagBuilder("input");
            Dictionary<string, string> phoneNumberAttributes = new Dictionary<string, string>();
            phoneNumberAttributes.Add("type", "text");
            phoneNumberAttributes.Add("name", "PhoneNumber");
            phoneNumberAttributes.Add("value", phoneRecord.PhoneNumber);
            inputPhoneNumber.MergeAttributes(phoneNumberAttributes);

            TagBuilder inputSubmit = new TagBuilder("input");
            Dictionary<string, string> submitAttributes = new Dictionary<string, string>();
            submitAttributes.Add("type", "submit");
            submitAttributes.Add("value", "Добавить");
            inputSubmit.MergeAttributes(submitAttributes);

            form.InnerHtml += inputId.ToString();
            form.InnerHtml += labelLastName.ToString();
            form.InnerHtml += inputLastName.ToString();
            form.InnerHtml += labelPhoneNumber.ToString();
            form.InnerHtml += inputPhoneNumber.ToString();
            form.InnerHtml += inputSubmit.ToString();

            return MvcHtmlString.Create(form.ToString());
        }
    }
}