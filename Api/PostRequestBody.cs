namespace RequestBody
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class PostRequestBody
    {


        public partial class Welcome
        {
            [JsonProperty("formProperties")]
            public FormProperties FormProperties { get; set; }

            [JsonProperty("emailConfig")]
            public EmailConfig EmailConfig { get; set; }

            [JsonProperty("viewMode")]
            public string ViewMode { get; set; }

            [JsonProperty("fields")]
            public Field[] Fields { get; set; }

            [JsonProperty("labelIds")]
            public string[] LabelIds { get; set; }
        }

        public partial class EmailConfig
        {
            [JsonProperty("sendToOwnerAndEmails")]
            public SendToOwnerAndEmails SendToOwnerAndEmails { get; set; }
        }

        public partial class SendToOwnerAndEmails
        {
            [JsonProperty("emailIds")]
            public object[] EmailIds { get; set; }
        }

        public partial class Field
        {
            [JsonProperty("fieldId")]
            public string FieldId { get; set; }

            [JsonProperty("label")]
            public string Label { get; set; }

            [JsonProperty("firstName", NullValueHandling = NullValueHandling.Ignore)]
            public FirstName FirstName { get; set; }

            [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
            public Email Email { get; set; }
        }

        public partial class Email
        {
            [JsonProperty("value")]
            public string Value { get; set; }

            [JsonProperty("tag")]
            public string Tag { get; set; }
        }

        public partial class FirstName
        {
            [JsonProperty("value")]
            public string Value { get; set; }
        }

        public partial class FormProperties
        {
            [JsonProperty("formName")]
            public string FormName { get; set; }

            [JsonProperty("formId")]
            public string FormId { get; set; }
        }
    }


    //    [JsonProperty("formProperties")]
    //    public FormProperties FormProperties { get; set; }

    //    [JsonProperty("emailConfig")]
    //    public EmailConfig EmailConfig { get; set; }

    //    [JsonProperty("fields")]
    //    public Field[] Fields { get; set; }
    //}

    //public partial class EmailConfig
    //{
    //    [JsonProperty("sendToOwnerAndEmails")]
    //    public SendToOwnerAndEmails SendToOwnerAndEmails { get; set; }
    //}

    //public partial class SendToOwnerAndEmails
    //{
    //    [JsonProperty("emailIds")]
    //    public object[] EmailIds { get; set; }
    //}

    //public partial class Field
    //{
    //    [JsonProperty("fieldId")]
    //    public string FieldId { get; set; }

    //    [JsonProperty("label")]
    //    public string Label { get; set; }

    //    [JsonProperty("firstName", NullValueHandling = NullValueHandling.Ignore)]
    //    public FirstName FirstName { get; set; }

    //    [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
    //    public Email Email { get; set; }
    //}

    //public partial class Email
    //{
    //    [JsonProperty("value")]
    //    public string Value { get; set; }

    //    [JsonProperty("tag")]
    //    public string Tag { get; set; }
    //}

    //public partial class FirstName
    //{
    //    [JsonProperty("value")]
    //    public string Value { get; set; }
    //}

    //public partial class FormProperties
    //{
    //    [JsonProperty("formName")]
    //    public string FormName { get; set; }

    //    [JsonProperty("formId")]
    //    public string FormId { get; set; }
    //}
}

