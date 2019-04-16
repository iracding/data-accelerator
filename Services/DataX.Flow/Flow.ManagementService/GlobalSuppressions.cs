﻿
// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1304:The behavior of 'string.ToLower()' could vary based on the current user's locale settings. Replace this call in 'FlowManagementController.FlowManagementController(ILogger<FlowManagementController>, FlowOperation, RuntimeConfigGeneration, JobOperation)' with a call to 'string.ToLower(CultureInfo)'.", Justification = "Critical issues only", Scope = "member", Target = "~M:Flow.Management.Controllers.FlowManagementController.#ctor(Microsoft.Extensions.Logging.ILogger{Flow.Management.Controllers.FlowManagementController},DataX.Config.PublicService.FlowOperation,DataX.Config.RuntimeConfigGeneration,DataX.Config.PublicService.JobOperation)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1307:The behavior of 'string.Equals(string)' could vary based on the current user's locale settings. Replace this call in 'Flow.Management.Controllers.FlowManagementController.FlowManagementController(Microsoft.Extensions.Logging.ILogger<Flow.Management.Controllers.FlowManagementController>, DataX.Config.PublicService.FlowOperation, DataX.Config.RuntimeConfigGeneration, DataX.Config.PublicService.JobOperation)' with a call to 'string.Equals(string, System.StringComparison)'.", Justification = "Critical issues only", Scope = "member", Target = "~M:Flow.Management.Controllers.FlowManagementController.#ctor(Microsoft.Extensions.Logging.ILogger{Flow.Management.Controllers.FlowManagementController},DataX.Config.PublicService.FlowOperation,DataX.Config.RuntimeConfigGeneration,DataX.Config.PublicService.JobOperation)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2007:Do not directly await a Task without calling ConfigureAwait", Justification = "Critical issues only", Scope = "member", Target = "~M:Flow.Management.Controllers.FlowManagementController.DeleteFlow(Newtonsoft.Json.Linq.JObject)~System.Threading.Tasks.Task{DataX.Contract.ApiResult}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2007:Do not directly await a Task without calling ConfigureAwait", Justification = "Critical issues only", Scope = "member", Target = "~M:Flow.Management.Controllers.FlowManagementController.GenerateConfigs(System.String)~System.Threading.Tasks.Task{DataX.Contract.ApiResult}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2007:Do not directly await a Task without calling ConfigureAwait", Justification = "Critical issues only", Scope = "member", Target = "~M:Flow.Management.Controllers.FlowManagementController.GetAllFlows~System.Threading.Tasks.Task{DataX.Contract.ApiResult}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2007:Do not directly await a Task without calling ConfigureAwait", Justification = "Critical issues only", Scope = "member", Target = "~M:Flow.Management.Controllers.FlowManagementController.GetAllFlowsMin~System.Threading.Tasks.Task{DataX.Contract.ApiResult}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2007:Do not directly await a Task without calling ConfigureAwait", Justification = "Critical issues only", Scope = "member", Target = "~M:Flow.Management.Controllers.FlowManagementController.GetAllJobs~System.Threading.Tasks.Task{DataX.Contract.ApiResult}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1307:The behavior of 'Newtonsoft.Json.Linq.JObject.GetValue(string)' could vary based on the current user's locale settings. Replace this call in 'Flow.Management.Controllers.FlowManagementController.GetCodeGen(Newtonsoft.Json.Linq.JObject)' with a call to 'Newtonsoft.Json.Linq.JObject.GetValue(string, System.StringComparison)'.", Justification = "Critical issues only", Scope = "member", Target = "~M:Flow.Management.Controllers.FlowManagementController.GetCodeGen(Newtonsoft.Json.Linq.JObject)~System.Threading.Tasks.Task{DataX.Contract.ApiResult}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2007:Do not directly await a Task without calling ConfigureAwait", Justification = "Critical issues only", Scope = "member", Target = "~M:Flow.Management.Controllers.FlowManagementController.GetFlow(System.String)~System.Threading.Tasks.Task{DataX.Contract.ApiResult}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2007:Do not directly await a Task without calling ConfigureAwait", Justification = "Critical issues only", Scope = "member", Target = "~M:Flow.Management.Controllers.FlowManagementController.GetJob(System.String)~System.Threading.Tasks.Task{DataX.Contract.ApiResult}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2007:Do not directly await a Task without calling ConfigureAwait", Justification = "Critical issues only", Scope = "member", Target = "~M:Flow.Management.Controllers.FlowManagementController.GetJobsByNames(System.String[])~System.Threading.Tasks.Task{DataX.Contract.ApiResult}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1307:The behavior of 'Newtonsoft.Json.Linq.JObject.GetValue(string)' could vary based on the current user's locale settings. Replace this call in 'Flow.Management.Controllers.FlowManagementController.GetSchema(Newtonsoft.Json.Linq.JObject)' with a call to 'Newtonsoft.Json.Linq.JObject.GetValue(string, System.StringComparison)'.", Justification = "Critical issues only", Scope = "member", Target = "~M:Flow.Management.Controllers.FlowManagementController.GetSchema(Newtonsoft.Json.Linq.JObject)~System.Threading.Tasks.Task{DataX.Contract.ApiResult}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2007:Do not directly await a Task without calling ConfigureAwait", Justification = "Critical issues only", Scope = "member", Target = "~M:Flow.Management.Controllers.FlowManagementController.RestartJob(System.String)~System.Threading.Tasks.Task{DataX.Contract.ApiResult}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2007:Do not directly await a Task without calling ConfigureAwait", Justification = "Critical issues only", Scope = "member", Target = "~M:Flow.Management.Controllers.FlowManagementController.RestartJobsForFlow(System.String)~System.Threading.Tasks.Task{DataX.Contract.ApiResult}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2007:Do not directly await a Task without calling ConfigureAwait", Justification = "Critical issues only", Scope = "member", Target = "~M:Flow.Management.Controllers.FlowManagementController.SaveFlow(Newtonsoft.Json.Linq.JObject)~System.Threading.Tasks.Task{DataX.Contract.ApiResult}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2007:Do not directly await a Task without calling ConfigureAwait", Justification = "Critical issues only", Scope = "member", Target = "~M:Flow.Management.Controllers.FlowManagementController.StartJob(System.String)~System.Threading.Tasks.Task{DataX.Contract.ApiResult}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2007:Do not directly await a Task without calling ConfigureAwait", Justification = "Critical issues only", Scope = "member", Target = "~M:Flow.Management.Controllers.FlowManagementController.StartJobsForFlow(System.String)~System.Threading.Tasks.Task{DataX.Contract.ApiResult}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2007:Do not directly await a Task without calling ConfigureAwait", Justification = "Critical issues only", Scope = "member", Target = "~M:Flow.Management.Controllers.FlowManagementController.StopJob(System.String)~System.Threading.Tasks.Task{DataX.Contract.ApiResult}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2007:Do not directly await a Task without calling ConfigureAwait", Justification = "Critical issues only", Scope = "member", Target = "~M:Flow.Management.Controllers.FlowManagementController.StopJobsForFlow(System.String)~System.Threading.Tasks.Task{DataX.Contract.ApiResult}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2007:Do not directly await a Task without calling ConfigureAwait", Justification = "Critical issues only", Scope = "member", Target = "~M:Flow.Management.Controllers.FlowManagementController.SyncAllJobs~System.Threading.Tasks.Task{DataX.Contract.ApiResult}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2007:Do not directly await a Task without calling ConfigureAwait", Justification = "Critical issues only", Scope = "member", Target = "~M:Flow.Management.Controllers.FlowManagementController.SyncJobsByNames(System.String[])~System.Threading.Tasks.Task{DataX.Contract.ApiResult}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, params object[])' could vary based on the current user's locale settings. Replace this call in 'ServiceEventSource.Message(string, params object[])' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "Critical issues only", Scope = "member", Target = "~M:Flow.Management.ServiceEventSource.Message(System.String,System.Object[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, params object[])' could vary based on the current user's locale settings. Replace this call in 'ServiceEventSource.ServiceMessage(ServiceContext, string, params object[])' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "Critical issues only", Scope = "member", Target = "~M:Flow.Management.ServiceEventSource.ServiceMessage(System.Fabric.ServiceContext,System.String,System.Object[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1801:Parameter loggerFactory of method Configure is never used. Remove the parameter or use it in the method body.", Justification = "Critical issues only", Scope = "member", Target = "~M:Flow.Management.Startup.Configure(Microsoft.AspNetCore.Builder.IApplicationBuilder,Microsoft.AspNetCore.Hosting.IHostingEnvironment,Microsoft.Extensions.Logging.ILoggerFactory)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1822:Member Configure does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "Critical issues only", Scope = "member", Target = "~M:Flow.Management.Startup.Configure(Microsoft.AspNetCore.Builder.IApplicationBuilder,Microsoft.AspNetCore.Hosting.IHostingEnvironment,Microsoft.Extensions.Logging.ILoggerFactory)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2007:Do not directly await a Task without calling ConfigureAwait", Justification = "Critical issues only", Scope = "member", Target = "~M:Flow.Management.Startup.GetDependencyAssembliesFromStorageAsync~System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{System.Reflection.Assembly}}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1307:The behavior of 'string.EndsWith(string)' could vary based on the current user's locale settings. Replace this call in 'Flow.Management.Startup.GetDependencyAssembliesFromStorageAsync()' with a call to 'string.EndsWith(string, System.StringComparison)'.", Justification = "Critical issues only", Scope = "member", Target = "~M:Flow.Management.Startup.GetDependencyAssembliesFromStorageAsync~System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{System.Reflection.Assembly}}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1822:Member GetDependencyAssembliesFromStorageAsync does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "Critical issues only", Scope = "member", Target = "~M:Flow.Management.Startup.GetDependencyAssembliesFromStorageAsync~System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{System.Reflection.Assembly}}")]