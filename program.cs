//Install Asp.Versioning.Http and Asp.Versioning.Mvc.ApiExplorer package

//Add api versioning
services.AddApiVersioning(options =>
{
	options.DefaultApiVersion = new ApiVersion(1); //default
	options.AssumeDefaultVersionWhenUnspecified = true; //لو مجلكش فيرجن اعتمد الديفولن
	options.ReportApiVersions = true; // اعرضله كل الفيرجنز في الهيدر
	options.ApiVersionReader = new HeaderApiVersionReader("api-version");// the key in header
}).AddApiExplorer(options =>
  {
	options.GroupNameFormat = "'v'V";
	options.SubstituteApiVersionInUrl = true;
  });

//On Controller
	[ApiVersion(1,Deprecated = true)]
	[ApiVersion(2)]

//On differenet action
	[ApiVersion(1)]
 //--
 	[ApiVersion(2)]
