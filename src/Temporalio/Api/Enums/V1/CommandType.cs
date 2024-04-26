// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: temporal/api/enums/v1/command_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Temporalio.Api.Enums.V1 {

  /// <summary>Holder for reflection information generated from temporal/api/enums/v1/command_type.proto</summary>
  public static partial class CommandTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for temporal/api/enums/v1/command_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CommandTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cih0ZW1wb3JhbC9hcGkvZW51bXMvdjEvY29tbWFuZF90eXBlLnByb3RvEhV0",
            "ZW1wb3JhbC5hcGkuZW51bXMudjEqwAUKC0NvbW1hbmRUeXBlEhwKGENPTU1B",
            "TkRfVFlQRV9VTlNQRUNJRklFRBAAEicKI0NPTU1BTkRfVFlQRV9TQ0hFRFVM",
            "RV9BQ1RJVklUWV9UQVNLEAESLQopQ09NTUFORF9UWVBFX1JFUVVFU1RfQ0FO",
            "Q0VMX0FDVElWSVRZX1RBU0sQAhIcChhDT01NQU5EX1RZUEVfU1RBUlRfVElN",
            "RVIQAxIsCihDT01NQU5EX1RZUEVfQ09NUExFVEVfV09SS0ZMT1dfRVhFQ1VU",
            "SU9OEAQSKAokQ09NTUFORF9UWVBFX0ZBSUxfV09SS0ZMT1dfRVhFQ1VUSU9O",
            "EAUSHQoZQ09NTUFORF9UWVBFX0NBTkNFTF9USU1FUhAGEioKJkNPTU1BTkRf",
            "VFlQRV9DQU5DRUxfV09SS0ZMT1dfRVhFQ1VUSU9OEAcSOwo3Q09NTUFORF9U",
            "WVBFX1JFUVVFU1RfQ0FOQ0VMX0VYVEVSTkFMX1dPUktGTE9XX0VYRUNVVElP",
            "ThAIEh4KGkNPTU1BTkRfVFlQRV9SRUNPUkRfTUFSS0VSEAkSMwovQ09NTUFO",
            "RF9UWVBFX0NPTlRJTlVFX0FTX05FV19XT1JLRkxPV19FWEVDVVRJT04QChIv",
            "CitDT01NQU5EX1RZUEVfU1RBUlRfQ0hJTERfV09SS0ZMT1dfRVhFQ1VUSU9O",
            "EAsSMwovQ09NTUFORF9UWVBFX1NJR05BTF9FWFRFUk5BTF9XT1JLRkxPV19F",
            "WEVDVVRJT04QDBIyCi5DT01NQU5EX1RZUEVfVVBTRVJUX1dPUktGTE9XX1NF",
            "QVJDSF9BVFRSSUJVVEVTEA0SIQodQ09NTUFORF9UWVBFX1BST1RPQ09MX01F",
            "U1NBR0UQDhIrCidDT01NQU5EX1RZUEVfTU9ESUZZX1dPUktGTE9XX1BST1BF",
            "UlRJRVMQEEKIAQoYaW8udGVtcG9yYWwuYXBpLmVudW1zLnYxQhBDb21tYW5k",
            "VHlwZVByb3RvUAFaIWdvLnRlbXBvcmFsLmlvL2FwaS9lbnVtcy92MTtlbnVt",
            "c6oCF1RlbXBvcmFsaW8uQXBpLkVudW1zLlYx6gIaVGVtcG9yYWxpbzo6QXBp",
            "OjpFbnVtczo6VjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Temporalio.Api.Enums.V1.CommandType), }, null, null));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// Whenever this list of command types is changed do change the function shouldBufferEvent in mutableStateBuilder.go to make sure to do the correct event ordering.
  /// </summary>
  public enum CommandType {
    [pbr::OriginalName("COMMAND_TYPE_UNSPECIFIED")] Unspecified = 0,
    [pbr::OriginalName("COMMAND_TYPE_SCHEDULE_ACTIVITY_TASK")] ScheduleActivityTask = 1,
    [pbr::OriginalName("COMMAND_TYPE_REQUEST_CANCEL_ACTIVITY_TASK")] RequestCancelActivityTask = 2,
    [pbr::OriginalName("COMMAND_TYPE_START_TIMER")] StartTimer = 3,
    [pbr::OriginalName("COMMAND_TYPE_COMPLETE_WORKFLOW_EXECUTION")] CompleteWorkflowExecution = 4,
    [pbr::OriginalName("COMMAND_TYPE_FAIL_WORKFLOW_EXECUTION")] FailWorkflowExecution = 5,
    [pbr::OriginalName("COMMAND_TYPE_CANCEL_TIMER")] CancelTimer = 6,
    [pbr::OriginalName("COMMAND_TYPE_CANCEL_WORKFLOW_EXECUTION")] CancelWorkflowExecution = 7,
    [pbr::OriginalName("COMMAND_TYPE_REQUEST_CANCEL_EXTERNAL_WORKFLOW_EXECUTION")] RequestCancelExternalWorkflowExecution = 8,
    [pbr::OriginalName("COMMAND_TYPE_RECORD_MARKER")] RecordMarker = 9,
    [pbr::OriginalName("COMMAND_TYPE_CONTINUE_AS_NEW_WORKFLOW_EXECUTION")] ContinueAsNewWorkflowExecution = 10,
    [pbr::OriginalName("COMMAND_TYPE_START_CHILD_WORKFLOW_EXECUTION")] StartChildWorkflowExecution = 11,
    [pbr::OriginalName("COMMAND_TYPE_SIGNAL_EXTERNAL_WORKFLOW_EXECUTION")] SignalExternalWorkflowExecution = 12,
    [pbr::OriginalName("COMMAND_TYPE_UPSERT_WORKFLOW_SEARCH_ATTRIBUTES")] UpsertWorkflowSearchAttributes = 13,
    [pbr::OriginalName("COMMAND_TYPE_PROTOCOL_MESSAGE")] ProtocolMessage = 14,
    [pbr::OriginalName("COMMAND_TYPE_MODIFY_WORKFLOW_PROPERTIES")] ModifyWorkflowProperties = 16,
  }

  #endregion

}

#endregion Designer generated code
