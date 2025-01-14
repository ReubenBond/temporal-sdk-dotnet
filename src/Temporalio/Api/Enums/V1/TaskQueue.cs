// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: temporal/api/enums/v1/task_queue.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Temporalio.Api.Enums.V1 {

  /// <summary>Holder for reflection information generated from temporal/api/enums/v1/task_queue.proto</summary>
  public static partial class TaskQueueReflection {

    #region Descriptor
    /// <summary>File descriptor for temporal/api/enums/v1/task_queue.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TaskQueueReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZ0ZW1wb3JhbC9hcGkvZW51bXMvdjEvdGFza19xdWV1ZS5wcm90bxIVdGVt",
            "cG9yYWwuYXBpLmVudW1zLnYxKmgKDVRhc2tRdWV1ZUtpbmQSHwobVEFTS19R",
            "VUVVRV9LSU5EX1VOU1BFQ0lGSUVEEAASGgoWVEFTS19RVUVVRV9LSU5EX05P",
            "Uk1BTBABEhoKFlRBU0tfUVVFVUVfS0lORF9TVElDS1kQAipsCg1UYXNrUXVl",
            "dWVUeXBlEh8KG1RBU0tfUVVFVUVfVFlQRV9VTlNQRUNJRklFRBAAEhwKGFRB",
            "U0tfUVVFVUVfVFlQRV9XT1JLRkxPVxABEhwKGFRBU0tfUVVFVUVfVFlQRV9B",
            "Q1RJVklUWRACKtIBChBUYXNrUmVhY2hhYmlsaXR5EiEKHVRBU0tfUkVBQ0hB",
            "QklMSVRZX1VOU1BFQ0lGSUVEEAASIwofVEFTS19SRUFDSEFCSUxJVFlfTkVX",
            "X1dPUktGTE9XUxABEigKJFRBU0tfUkVBQ0hBQklMSVRZX0VYSVNUSU5HX1dP",
            "UktGTE9XUxACEiQKIFRBU0tfUkVBQ0hBQklMSVRZX09QRU5fV09SS0ZMT1dT",
            "EAMSJgoiVEFTS19SRUFDSEFCSUxJVFlfQ0xPU0VEX1dPUktGTE9XUxAEQoYB",
            "Chhpby50ZW1wb3JhbC5hcGkuZW51bXMudjFCDlRhc2tRdWV1ZVByb3RvUAFa",
            "IWdvLnRlbXBvcmFsLmlvL2FwaS9lbnVtcy92MTtlbnVtc6oCF1RlbXBvcmFs",
            "aW8uQXBpLkVudW1zLlYx6gIaVGVtcG9yYWxpbzo6QXBpOjpFbnVtczo6VjFi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Temporalio.Api.Enums.V1.TaskQueueKind), typeof(global::Temporalio.Api.Enums.V1.TaskQueueType), typeof(global::Temporalio.Api.Enums.V1.TaskReachability), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum TaskQueueKind {
    [pbr::OriginalName("TASK_QUEUE_KIND_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// Tasks from a normal workflow task queue always include complete workflow history
    ///
    /// The task queue specified by the user is always a normal task queue. There can be as many
    /// workers as desired for a single normal task queue. All those workers may pick up tasks from
    /// that queue.
    /// </summary>
    [pbr::OriginalName("TASK_QUEUE_KIND_NORMAL")] Normal = 1,
    /// <summary>
    /// A sticky queue only includes new history since the last workflow task, and they are
    /// per-worker.
    ///
    /// Sticky queues are created dynamically by each worker during their start up. They only exist
    /// for the lifetime of the worker process. Tasks in a sticky task queue are only available to
    /// the worker that created the sticky queue.
    ///
    /// Sticky queues are only for workflow tasks. There are no sticky task queues for activities.
    /// </summary>
    [pbr::OriginalName("TASK_QUEUE_KIND_STICKY")] Sticky = 2,
  }

  public enum TaskQueueType {
    [pbr::OriginalName("TASK_QUEUE_TYPE_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// Workflow type of task queue.
    /// </summary>
    [pbr::OriginalName("TASK_QUEUE_TYPE_WORKFLOW")] Workflow = 1,
    /// <summary>
    /// Activity type of task queue.
    /// </summary>
    [pbr::OriginalName("TASK_QUEUE_TYPE_ACTIVITY")] Activity = 2,
  }

  /// <summary>
  /// Specifies which category of tasks may reach a worker on a versioned task queue.
  /// Used both in a reachability query and its response.
  /// </summary>
  public enum TaskReachability {
    [pbr::OriginalName("TASK_REACHABILITY_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// There's a possiblity for a worker to receive new workflow tasks. Workers should *not* be retired.
    /// </summary>
    [pbr::OriginalName("TASK_REACHABILITY_NEW_WORKFLOWS")] NewWorkflows = 1,
    /// <summary>
    /// There's a possiblity for a worker to receive existing workflow and activity tasks from existing workflows. Workers
    /// should *not* be retired.
    /// This enum value does not distinguish between open and closed workflows.
    /// </summary>
    [pbr::OriginalName("TASK_REACHABILITY_EXISTING_WORKFLOWS")] ExistingWorkflows = 2,
    /// <summary>
    /// There's a possiblity for a worker to receive existing workflow and activity tasks from open workflows. Workers
    /// should *not* be retired.
    /// </summary>
    [pbr::OriginalName("TASK_REACHABILITY_OPEN_WORKFLOWS")] OpenWorkflows = 3,
    /// <summary>
    /// There's a possiblity for a worker to receive existing workflow tasks from closed workflows. Workers may be
    /// retired dependending on application requirements. For example, if there's no need to query closed workflows.
    /// </summary>
    [pbr::OriginalName("TASK_REACHABILITY_CLOSED_WORKFLOWS")] ClosedWorkflows = 4,
  }

  #endregion

}

#endregion Designer generated code
