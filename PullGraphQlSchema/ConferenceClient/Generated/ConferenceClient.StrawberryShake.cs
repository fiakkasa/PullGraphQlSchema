﻿// SessionEntity.cs
#nullable enable

namespace PullGraphQlSchema.GraphQL.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class SessionEntity
    {
        public SessionEntity(
            global::System.String title,
            global::System.DateTimeOffset? startTime,
            global::System.DateTimeOffset? endTime,
            global::System.String? description,
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId> speakers)
        {
            Title = title;
            StartTime = startTime;
            EndTime = endTime;
            Description = description;
            Speakers = speakers;
        }

        public global::System.String Title { get; }

        public global::System.DateTimeOffset? StartTime { get; }

        public global::System.DateTimeOffset? EndTime { get; }

        public global::System.String? Description { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId> Speakers { get; }
    }
}


// SpeakerEntity.cs
#nullable enable

namespace PullGraphQlSchema.GraphQL.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class SpeakerEntity
    {
        public SpeakerEntity(global::System.String name)
        {
            Name = name;
        }

        public global::System.String Name { get; }
    }
}


// GetSessionsResultFactory.cs
#nullable enable

namespace PullGraphQlSchema.GraphQL.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetSessionsResultFactory
        : global::StrawberryShake.IOperationResultDataFactory<global::PullGraphQlSchema.GraphQL.GetSessionsResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityMapper<global::PullGraphQlSchema.GraphQL.State.SessionEntity, GetSessions_Sessions_Nodes_Session> _getSessions_Sessions_Nodes_SessionFromSessionEntityMapper;
        private readonly global::StrawberryShake.IEntityMapper<global::PullGraphQlSchema.GraphQL.State.SpeakerEntity, GetSessions_Sessions_Nodes_Speakers_Speaker> _getSessions_Sessions_Nodes_Speakers_SpeakerFromSpeakerEntityMapper;

        public GetSessionsResultFactory(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityMapper<global::PullGraphQlSchema.GraphQL.State.SessionEntity, GetSessions_Sessions_Nodes_Session> getSessions_Sessions_Nodes_SessionFromSessionEntityMapper,
            global::StrawberryShake.IEntityMapper<global::PullGraphQlSchema.GraphQL.State.SpeakerEntity, GetSessions_Sessions_Nodes_Speakers_Speaker> getSessions_Sessions_Nodes_Speakers_SpeakerFromSpeakerEntityMapper)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _getSessions_Sessions_Nodes_SessionFromSessionEntityMapper = getSessions_Sessions_Nodes_SessionFromSessionEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getSessions_Sessions_Nodes_SessionFromSessionEntityMapper));
            _getSessions_Sessions_Nodes_Speakers_SpeakerFromSpeakerEntityMapper = getSessions_Sessions_Nodes_Speakers_SpeakerFromSpeakerEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getSessions_Sessions_Nodes_Speakers_SpeakerFromSpeakerEntityMapper));
        }

        global::System.Type global::StrawberryShake.IOperationResultDataFactory.ResultType => typeof(global::PullGraphQlSchema.GraphQL.IGetSessionsResult);

        public GetSessionsResult Create(
            global::StrawberryShake.IOperationResultDataInfo dataInfo,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            if (dataInfo is GetSessionsResultInfo info)
            {
                return new GetSessionsResult(MapIGetSessions_Sessions(
                    info.Sessions,
                    snapshot));
            }

            throw new global::System.ArgumentException("GetSessionsResultInfo expected.");
        }

        private global::PullGraphQlSchema.GraphQL.IGetSessions_Sessions? MapIGetSessions_Sessions(
            global::PullGraphQlSchema.GraphQL.State.SessionConnectionData? data,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (data is null)
            {
                return null;
            }

            IGetSessions_Sessions returnValue = default!;

            if (data?.__typename.Equals(
                    "SessionConnection",
                    global::System.StringComparison.Ordinal) ?? false)
            {
                returnValue = new GetSessions_Sessions_SessionConnection(MapIGetSessions_Sessions_NodesNonNullableArray(
                    data.Nodes,
                    snapshot));
            }
            else
            {
                throw new global::System.NotSupportedException();
            }
            return returnValue;
        }

        private global::System.Collections.Generic.IReadOnlyList<global::PullGraphQlSchema.GraphQL.IGetSessions_Sessions_Nodes>? MapIGetSessions_Sessions_NodesNonNullableArray(
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId>? list,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (list is null)
            {
                return null;
            }

            var sessions = new global::System.Collections.Generic.List<global::PullGraphQlSchema.GraphQL.IGetSessions_Sessions_Nodes>();

            foreach (global::StrawberryShake.EntityId child in list)
            {
                sessions.Add(MapNonNullableIGetSessions_Sessions_Nodes(
                    child,
                    snapshot));
            }

            return sessions;
        }

        private global::PullGraphQlSchema.GraphQL.IGetSessions_Sessions_Nodes MapNonNullableIGetSessions_Sessions_Nodes(
            global::StrawberryShake.EntityId entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {

            if (entityId.Name.Equals(
                    "Session",
                    global::System.StringComparison.Ordinal))
            {
                return _getSessions_Sessions_Nodes_SessionFromSessionEntityMapper.Map(
                    snapshot.GetEntity<global::PullGraphQlSchema.GraphQL.State.SessionEntity>(entityId)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }

        private global::System.Collections.Generic.IReadOnlyList<global::PullGraphQlSchema.GraphQL.IGetSessions_Sessions_Nodes_Speakers> MapNonNullableIGetSessions_Sessions_Nodes_SpeakersNonNullableArray(
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId>? list,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (list is null)
            {
                throw new global::System.ArgumentNullException();
            }

            var speakers = new global::System.Collections.Generic.List<global::PullGraphQlSchema.GraphQL.IGetSessions_Sessions_Nodes_Speakers>();

            foreach (global::StrawberryShake.EntityId child in list)
            {
                speakers.Add(MapNonNullableIGetSessions_Sessions_Nodes_Speakers(
                    child,
                    snapshot));
            }

            return speakers;
        }

        private global::PullGraphQlSchema.GraphQL.IGetSessions_Sessions_Nodes_Speakers MapNonNullableIGetSessions_Sessions_Nodes_Speakers(
            global::StrawberryShake.EntityId entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {

            if (entityId.Name.Equals(
                    "Speaker",
                    global::System.StringComparison.Ordinal))
            {
                return _getSessions_Sessions_Nodes_Speakers_SpeakerFromSpeakerEntityMapper.Map(
                    snapshot.GetEntity<global::PullGraphQlSchema.GraphQL.State.SpeakerEntity>(entityId)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }

        global::System.Object global::StrawberryShake.IOperationResultDataFactory.Create(
            global::StrawberryShake.IOperationResultDataInfo dataInfo,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot)
        {
            return Create(
                dataInfo,
                snapshot);
        }
    }
}


// GetSessionsResultInfo.cs
#nullable enable

namespace PullGraphQlSchema.GraphQL.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetSessionsResultInfo
        : global::StrawberryShake.IOperationResultDataInfo
    {
        private readonly global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> _entityIds;
        private readonly global::System.UInt64 _version;

        public GetSessionsResultInfo(
            global::PullGraphQlSchema.GraphQL.State.SessionConnectionData? sessions,
            global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> entityIds,
            global::System.UInt64 version)
        {
            Sessions = sessions;
            _entityIds = entityIds
                 ?? throw new global::System.ArgumentNullException(nameof(entityIds));
            _version = version;
        }

        public global::PullGraphQlSchema.GraphQL.State.SessionConnectionData? Sessions { get; }

        public global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> EntityIds => _entityIds;

        public global::System.UInt64 Version => _version;

        public global::StrawberryShake.IOperationResultDataInfo WithVersion(global::System.UInt64 version)
        {
            return new GetSessionsResultInfo(
                Sessions,
                _entityIds,
                version);
        }
    }
}


// GetSessionsResult.cs
#nullable enable

namespace PullGraphQlSchema.GraphQL
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetSessionsResult
        : global::System.IEquatable<GetSessionsResult>
        , IGetSessionsResult
    {
        public GetSessionsResult(global::PullGraphQlSchema.GraphQL.IGetSessions_Sessions? sessions)
        {
            Sessions = sessions;
        }

        public global::PullGraphQlSchema.GraphQL.IGetSessions_Sessions? Sessions { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetSessionsResult)obj);
        }

        public global::System.Boolean Equals(GetSessionsResult? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (((Sessions is null && other.Sessions is null) ||Sessions != null && Sessions.Equals(other.Sessions)));
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                if (!(Sessions is null))
                {
                    hash ^= 397 * Sessions.GetHashCode();
                }

                return hash;
            }
        }
    }
}


// GetSessions_Sessions_SessionConnection.cs
#nullable enable

namespace PullGraphQlSchema.GraphQL
{
    /// <summary>
    /// A connection to a list of items.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetSessions_Sessions_SessionConnection
        : global::System.IEquatable<GetSessions_Sessions_SessionConnection>
        , IGetSessions_Sessions_SessionConnection
    {
        public GetSessions_Sessions_SessionConnection(global::System.Collections.Generic.IReadOnlyList<global::PullGraphQlSchema.GraphQL.IGetSessions_Sessions_Nodes>? nodes)
        {
            Nodes = nodes;
        }

        /// <summary>
        /// A flattened list of the nodes.
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<global::PullGraphQlSchema.GraphQL.IGetSessions_Sessions_Nodes>? Nodes { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetSessions_Sessions_SessionConnection)obj);
        }

        public global::System.Boolean Equals(GetSessions_Sessions_SessionConnection? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(
                        Nodes,
                        other.Nodes));
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                if (!(Nodes is null))
                {
                    foreach (var Nodes_elm in Nodes)
                    {
                        hash ^= 397 * Nodes_elm.GetHashCode();
                    }
                }

                return hash;
            }
        }
    }
}


// GetSessions_Sessions_Nodes_SessionFromSessionEntityMapper.cs
#nullable enable

namespace PullGraphQlSchema.GraphQL.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetSessions_Sessions_Nodes_SessionFromSessionEntityMapper
        : global::StrawberryShake.IEntityMapper<global::PullGraphQlSchema.GraphQL.State.SessionEntity, GetSessions_Sessions_Nodes_Session>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityMapper<global::PullGraphQlSchema.GraphQL.State.SpeakerEntity, GetSessions_Sessions_Nodes_Speakers_Speaker> _getSessions_Sessions_Nodes_Speakers_SpeakerFromSpeakerEntityMapper;

        public GetSessions_Sessions_Nodes_SessionFromSessionEntityMapper(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityMapper<global::PullGraphQlSchema.GraphQL.State.SpeakerEntity, GetSessions_Sessions_Nodes_Speakers_Speaker> getSessions_Sessions_Nodes_Speakers_SpeakerFromSpeakerEntityMapper)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _getSessions_Sessions_Nodes_Speakers_SpeakerFromSpeakerEntityMapper = getSessions_Sessions_Nodes_Speakers_SpeakerFromSpeakerEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getSessions_Sessions_Nodes_Speakers_SpeakerFromSpeakerEntityMapper));
        }

        public GetSessions_Sessions_Nodes_Session Map(
            global::PullGraphQlSchema.GraphQL.State.SessionEntity entity,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            return new GetSessions_Sessions_Nodes_Session(
                entity.Title,
                entity.StartTime,
                entity.EndTime,
                entity.Description,
                MapNonNullableIGetSessions_Sessions_Nodes_SpeakersNonNullableArray(
                    entity.Speakers,
                    snapshot));
        }

        private global::System.Collections.Generic.IReadOnlyList<global::PullGraphQlSchema.GraphQL.IGetSessions_Sessions_Nodes_Speakers> MapNonNullableIGetSessions_Sessions_Nodes_SpeakersNonNullableArray(
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId>? list,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (list is null)
            {
                throw new global::System.ArgumentNullException();
            }

            var speakers = new global::System.Collections.Generic.List<global::PullGraphQlSchema.GraphQL.IGetSessions_Sessions_Nodes_Speakers>();

            foreach (global::StrawberryShake.EntityId child in list)
            {
                speakers.Add(MapNonNullableIGetSessions_Sessions_Nodes_Speakers(
                    child,
                    snapshot));
            }

            return speakers;
        }

        private global::PullGraphQlSchema.GraphQL.IGetSessions_Sessions_Nodes_Speakers MapNonNullableIGetSessions_Sessions_Nodes_Speakers(
            global::StrawberryShake.EntityId entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {

            if (entityId.Name.Equals(
                    "Speaker",
                    global::System.StringComparison.Ordinal))
            {
                return _getSessions_Sessions_Nodes_Speakers_SpeakerFromSpeakerEntityMapper.Map(
                    snapshot.GetEntity<global::PullGraphQlSchema.GraphQL.State.SpeakerEntity>(entityId)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }
    }
}


// GetSessions_Sessions_Nodes_Session.cs
#nullable enable

namespace PullGraphQlSchema.GraphQL
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetSessions_Sessions_Nodes_Session
        : global::System.IEquatable<GetSessions_Sessions_Nodes_Session>
        , IGetSessions_Sessions_Nodes_Session
    {
        public GetSessions_Sessions_Nodes_Session(
            global::System.String title,
            global::System.DateTimeOffset? startTime,
            global::System.DateTimeOffset? endTime,
            global::System.String? description,
            global::System.Collections.Generic.IReadOnlyList<global::PullGraphQlSchema.GraphQL.IGetSessions_Sessions_Nodes_Speakers> speakers)
        {
            Title = title;
            StartTime = startTime;
            EndTime = endTime;
            Description = description;
            Speakers = speakers;
        }

        public global::System.String Title { get; }

        public global::System.DateTimeOffset? StartTime { get; }

        public global::System.DateTimeOffset? EndTime { get; }

        public global::System.String? Description { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::PullGraphQlSchema.GraphQL.IGetSessions_Sessions_Nodes_Speakers> Speakers { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetSessions_Sessions_Nodes_Session)obj);
        }

        public global::System.Boolean Equals(GetSessions_Sessions_Nodes_Session? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (Title.Equals(other.Title))
                && ((StartTime is null && other.StartTime is null) ||StartTime != null && StartTime.Equals(other.StartTime))
                && ((EndTime is null && other.EndTime is null) ||EndTime != null && EndTime.Equals(other.EndTime))
                && ((Description is null && other.Description is null) ||Description != null && Description.Equals(other.Description))
                && global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(
                        Speakers,
                        other.Speakers);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                hash ^= 397 * Title.GetHashCode();

                if (!(StartTime is null))
                {
                    hash ^= 397 * StartTime.GetHashCode();
                }

                if (!(EndTime is null))
                {
                    hash ^= 397 * EndTime.GetHashCode();
                }

                if (!(Description is null))
                {
                    hash ^= 397 * Description.GetHashCode();
                }

                foreach (var Speakers_elm in Speakers)
                {
                    hash ^= 397 * Speakers_elm.GetHashCode();
                }

                return hash;
            }
        }
    }
}


// GetSessions_Sessions_Nodes_Speakers_SpeakerFromSpeakerEntityMapper.cs
#nullable enable

namespace PullGraphQlSchema.GraphQL.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetSessions_Sessions_Nodes_Speakers_SpeakerFromSpeakerEntityMapper
        : global::StrawberryShake.IEntityMapper<global::PullGraphQlSchema.GraphQL.State.SpeakerEntity, GetSessions_Sessions_Nodes_Speakers_Speaker>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;

        public GetSessions_Sessions_Nodes_Speakers_SpeakerFromSpeakerEntityMapper(global::StrawberryShake.IEntityStore entityStore)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
        }

        public GetSessions_Sessions_Nodes_Speakers_Speaker Map(
            global::PullGraphQlSchema.GraphQL.State.SpeakerEntity entity,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            return new GetSessions_Sessions_Nodes_Speakers_Speaker(entity.Name);
        }
    }
}


// GetSessions_Sessions_Nodes_Speakers_Speaker.cs
#nullable enable

namespace PullGraphQlSchema.GraphQL
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetSessions_Sessions_Nodes_Speakers_Speaker
        : global::System.IEquatable<GetSessions_Sessions_Nodes_Speakers_Speaker>
        , IGetSessions_Sessions_Nodes_Speakers_Speaker
    {
        public GetSessions_Sessions_Nodes_Speakers_Speaker(global::System.String name)
        {
            Name = name;
        }

        public global::System.String Name { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetSessions_Sessions_Nodes_Speakers_Speaker)obj);
        }

        public global::System.Boolean Equals(GetSessions_Sessions_Nodes_Speakers_Speaker? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (Name.Equals(other.Name));
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                hash ^= 397 * Name.GetHashCode();

                return hash;
            }
        }
    }
}


// IGetSessionsResult.cs
#nullable enable

namespace PullGraphQlSchema.GraphQL
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetSessionsResult
    {
        public global::PullGraphQlSchema.GraphQL.IGetSessions_Sessions? Sessions { get; }
    }
}


// IGetSessions_Sessions.cs
#nullable enable

namespace PullGraphQlSchema.GraphQL
{
    /// <summary>
    /// A connection to a list of items.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetSessions_Sessions
    {
        /// <summary>
        /// A flattened list of the nodes.
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<global::PullGraphQlSchema.GraphQL.IGetSessions_Sessions_Nodes>? Nodes { get; }
    }
}


// IGetSessions_Sessions_SessionConnection.cs
#nullable enable

namespace PullGraphQlSchema.GraphQL
{
    /// <summary>
    /// A connection to a list of items.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetSessions_Sessions_SessionConnection
        : IGetSessions_Sessions
    {
    }
}


// IGetSessions_Sessions_Nodes.cs
#nullable enable

namespace PullGraphQlSchema.GraphQL
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetSessions_Sessions_Nodes
    {
        public global::System.String Title { get; }

        public global::System.DateTimeOffset? StartTime { get; }

        public global::System.DateTimeOffset? EndTime { get; }

        public global::System.String? Description { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::PullGraphQlSchema.GraphQL.IGetSessions_Sessions_Nodes_Speakers> Speakers { get; }
    }
}


// IGetSessions_Sessions_Nodes_Session.cs
#nullable enable

namespace PullGraphQlSchema.GraphQL
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetSessions_Sessions_Nodes_Session
        : IGetSessions_Sessions_Nodes
    {
    }
}


// IGetSessions_Sessions_Nodes_Speakers.cs
#nullable enable

namespace PullGraphQlSchema.GraphQL
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetSessions_Sessions_Nodes_Speakers
    {
        public global::System.String Name { get; }
    }
}


// IGetSessions_Sessions_Nodes_Speakers_Speaker.cs
#nullable enable

namespace PullGraphQlSchema.GraphQL
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetSessions_Sessions_Nodes_Speakers_Speaker
        : IGetSessions_Sessions_Nodes_Speakers
    {
    }
}


// GetSessionsQueryDocument.cs
#nullable enable

namespace PullGraphQlSchema.GraphQL
{
    /// <summary>
    /// Represents the operation service of the GetSessions GraphQL operation
    /// <code>
    /// query GetSessions {
    ///   sessions(order: { title: ASC }) {
    ///     __typename
    ///     nodes {
    ///       __typename
    ///       title
    ///       startTime
    ///       endTime
    ///       description: abstract
    ///       speakers {
    ///         __typename
    ///         name
    ///         ... on Speaker {
    ///           id
    ///         }
    ///       }
    ///       ... on Session {
    ///         id
    ///       }
    ///     }
    ///   }
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetSessionsQueryDocument
        : global::StrawberryShake.IDocument
    {
        private GetSessionsQueryDocument()
        {
        }

        public static GetSessionsQueryDocument Instance { get; } = new GetSessionsQueryDocument();

        public global::StrawberryShake.OperationKind Kind => global::StrawberryShake.OperationKind.Query;

        public global::System.ReadOnlySpan<global::System.Byte> Body => new global::System.Byte[]{ 0x71, 0x75, 0x65, 0x72, 0x79, 0x20, 0x47, 0x65, 0x74, 0x53, 0x65, 0x73, 0x73, 0x69, 0x6f, 0x6e, 0x73, 0x20, 0x7b, 0x20, 0x73, 0x65, 0x73, 0x73, 0x69, 0x6f, 0x6e, 0x73, 0x28, 0x6f, 0x72, 0x64, 0x65, 0x72, 0x3a, 0x20, 0x7b, 0x20, 0x74, 0x69, 0x74, 0x6c, 0x65, 0x3a, 0x20, 0x41, 0x53, 0x43, 0x20, 0x7d, 0x29, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x6e, 0x6f, 0x64, 0x65, 0x73, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x74, 0x69, 0x74, 0x6c, 0x65, 0x20, 0x73, 0x74, 0x61, 0x72, 0x74, 0x54, 0x69, 0x6d, 0x65, 0x20, 0x65, 0x6e, 0x64, 0x54, 0x69, 0x6d, 0x65, 0x20, 0x64, 0x65, 0x73, 0x63, 0x72, 0x69, 0x70, 0x74, 0x69, 0x6f, 0x6e, 0x3a, 0x20, 0x61, 0x62, 0x73, 0x74, 0x72, 0x61, 0x63, 0x74, 0x20, 0x73, 0x70, 0x65, 0x61, 0x6b, 0x65, 0x72, 0x73, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x6f, 0x6e, 0x20, 0x53, 0x70, 0x65, 0x61, 0x6b, 0x65, 0x72, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x6f, 0x6e, 0x20, 0x53, 0x65, 0x73, 0x73, 0x69, 0x6f, 0x6e, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x7d };

        public global::StrawberryShake.DocumentHash Hash { get; } = new global::StrawberryShake.DocumentHash("sha1Hash", "e9e2d7066b65415cec0ab5553b86bf7614ae2332");

        public override global::System.String ToString()
        {
            #if NETSTANDARD2_0
            return global::System.Text.Encoding.UTF8.GetString(Body.ToArray());
            #else
            return global::System.Text.Encoding.UTF8.GetString(Body);
            #endif
        }
    }
}


// GetSessionsQuery.cs
#nullable enable

namespace PullGraphQlSchema.GraphQL
{
    /// <summary>
    /// Represents the operation service of the GetSessions GraphQL operation
    /// <code>
    /// query GetSessions {
    ///   sessions(order: { title: ASC }) {
    ///     __typename
    ///     nodes {
    ///       __typename
    ///       title
    ///       startTime
    ///       endTime
    ///       description: abstract
    ///       speakers {
    ///         __typename
    ///         name
    ///         ... on Speaker {
    ///           id
    ///         }
    ///       }
    ///       ... on Session {
    ///         id
    ///       }
    ///     }
    ///   }
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetSessionsQuery
        : global::PullGraphQlSchema.GraphQL.IGetSessionsQuery
    {
        private readonly global::StrawberryShake.IOperationExecutor<IGetSessionsResult> _operationExecutor;

        public GetSessionsQuery(global::StrawberryShake.IOperationExecutor<IGetSessionsResult> operationExecutor)
        {
            _operationExecutor = operationExecutor
                 ?? throw new global::System.ArgumentNullException(nameof(operationExecutor));
        }

        global::System.Type global::StrawberryShake.IOperationRequestFactory.ResultType => typeof(IGetSessionsResult);

        public async global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<IGetSessionsResult>> ExecuteAsync(global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = CreateRequest();

            return await _operationExecutor
                .ExecuteAsync(
                    request,
                    cancellationToken)
                .ConfigureAwait(false);
        }

        public global::System.IObservable<global::StrawberryShake.IOperationResult<IGetSessionsResult>> Watch(global::StrawberryShake.ExecutionStrategy? strategy = null)
        {
            var request = CreateRequest();
            return _operationExecutor.Watch(
                request,
                strategy);
        }

        private global::StrawberryShake.OperationRequest CreateRequest()
        {

            return CreateRequest(null);
        }

        private global::StrawberryShake.OperationRequest CreateRequest(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {

            return new global::StrawberryShake.OperationRequest(
                id: GetSessionsQueryDocument.Instance.Hash.Value,
                name: "GetSessions",
                document: GetSessionsQueryDocument.Instance,
                strategy: global::StrawberryShake.RequestStrategy.Default);
        }

        global::StrawberryShake.OperationRequest global::StrawberryShake.IOperationRequestFactory.Create(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {
            return CreateRequest();
        }
    }
}


// IGetSessionsQuery.cs
#nullable enable

namespace PullGraphQlSchema.GraphQL
{
    /// <summary>
    /// Represents the operation service of the GetSessions GraphQL operation
    /// <code>
    /// query GetSessions {
    ///   sessions(order: { title: ASC }) {
    ///     __typename
    ///     nodes {
    ///       __typename
    ///       title
    ///       startTime
    ///       endTime
    ///       description: abstract
    ///       speakers {
    ///         __typename
    ///         name
    ///         ... on Speaker {
    ///           id
    ///         }
    ///       }
    ///       ... on Session {
    ///         id
    ///       }
    ///     }
    ///   }
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetSessionsQuery
        : global::StrawberryShake.IOperationRequestFactory
    {
        global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<IGetSessionsResult>> ExecuteAsync(global::System.Threading.CancellationToken cancellationToken = default);

        global::System.IObservable<global::StrawberryShake.IOperationResult<IGetSessionsResult>> Watch(global::StrawberryShake.ExecutionStrategy? strategy = null);
    }
}


// GetSessionsBuilder.cs
#nullable enable

namespace PullGraphQlSchema.GraphQL.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetSessionsBuilder
        : global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::PullGraphQlSchema.GraphQL.IGetSessionsResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityIdSerializer _idSerializer;
        private readonly global::StrawberryShake.IOperationResultDataFactory<global::PullGraphQlSchema.GraphQL.IGetSessionsResult> _resultDataFactory;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::System.String> _stringParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::System.DateTimeOffset> _dateTimeParser;

        public GetSessionsBuilder(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityIdSerializer idSerializer,
            global::StrawberryShake.IOperationResultDataFactory<global::PullGraphQlSchema.GraphQL.IGetSessionsResult> resultDataFactory,
            global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _idSerializer = idSerializer
                 ?? throw new global::System.ArgumentNullException(nameof(idSerializer));
            _resultDataFactory = resultDataFactory
                 ?? throw new global::System.ArgumentNullException(nameof(resultDataFactory));
            _stringParser = serializerResolver.GetLeafValueParser<global::System.String, global::System.String>("String")
                 ?? throw new global::System.ArgumentException("No serializer for type `String` found.");
            _dateTimeParser = serializerResolver.GetLeafValueParser<global::System.String, global::System.DateTimeOffset>("DateTime")
                 ?? throw new global::System.ArgumentException("No serializer for type `DateTime` found.");
        }

        public global::StrawberryShake.IOperationResult<IGetSessionsResult> Build(global::StrawberryShake.Response<global::System.Text.Json.JsonDocument> response)
        {
            (IGetSessionsResult Result, GetSessionsResultInfo Info)? data = null;
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.IClientError>? errors = null;

            try
            {
                if (response.Body != null)
                {
                    if (response.Body.RootElement.TryGetProperty("data", out global::System.Text.Json.JsonElement dataElement) && dataElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        data = BuildData(dataElement);
                    }
                    if (response.Body.RootElement.TryGetProperty("errors", out global::System.Text.Json.JsonElement errorsElement))
                    {
                        errors = global::StrawberryShake.Json.JsonErrorParser.ParseErrors(errorsElement);
                    }
                }
            }
            catch(global::System.Exception ex)
            {
                errors = new global::StrawberryShake.IClientError[] {
                    new global::StrawberryShake.ClientError(
                        ex.Message,
                        exception: ex)
                };
            }

            return new global::StrawberryShake.OperationResult<IGetSessionsResult>(
                data?.Result,
                data?.Info,
                _resultDataFactory,
                errors);
        }

        private (IGetSessionsResult, GetSessionsResultInfo) BuildData(global::System.Text.Json.JsonElement obj)
        {
            var entityIds = new global::System.Collections.Generic.HashSet<global::StrawberryShake.EntityId>();
            global::StrawberryShake.IEntityStoreSnapshot snapshot = default!;

            global::PullGraphQlSchema.GraphQL.State.SessionConnectionData? sessionsId = default!;
            _entityStore.Update(session => 
            {
                sessionsId = DeserializeIGetSessions_Sessions(
                    session,
                    global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "sessions"),
                    entityIds);

                snapshot = session.CurrentSnapshot;
            });

            var resultInfo = new GetSessionsResultInfo(
                sessionsId,
                entityIds,
                snapshot.Version);

            return (
                _resultDataFactory.Create(resultInfo),
                resultInfo
            );
        }

        private global::PullGraphQlSchema.GraphQL.State.SessionConnectionData? DeserializeIGetSessions_Sessions(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            var typename = obj.Value
                .GetProperty("__typename")
                .GetString();

            if (typename?.Equals("SessionConnection", global::System.StringComparison.Ordinal) ?? false)
            {
                return new global::PullGraphQlSchema.GraphQL.State.SessionConnectionData(
                    typename,
                    nodes: UpdateIGetSessions_Sessions_NodesEntityNonNullableArray(
                        session,
                        global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                            obj,
                            "nodes"),
                        entityIds));
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId>? UpdateIGetSessions_Sessions_NodesEntityNonNullableArray(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            var sessions = new global::System.Collections.Generic.List<global::StrawberryShake.EntityId>();

            foreach (global::System.Text.Json.JsonElement child in obj.Value.EnumerateArray())
            {
                sessions.Add(UpdateNonNullableIGetSessions_Sessions_NodesEntity(
                    session,
                    child,
                    entityIds));
            }

            return sessions;
        }

        private global::StrawberryShake.EntityId UpdateNonNullableIGetSessions_Sessions_NodesEntity(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            global::StrawberryShake.EntityId entityId = _idSerializer.Parse(obj.Value);
            entityIds.Add(entityId);


            if (entityId.Name.Equals(
                    "Session",
                    global::System.StringComparison.Ordinal))
            {
                if (session.CurrentSnapshot.TryGetEntity(
                        entityId,
                        out global::PullGraphQlSchema.GraphQL.State.SessionEntity? entity))
                {
                    session.SetEntity(
                        entityId,
                        new global::PullGraphQlSchema.GraphQL.State.SessionEntity(
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "title")),
                            DeserializeDateTimeOffset(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "startTime")),
                            DeserializeDateTimeOffset(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "endTime")),
                            DeserializeString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "description")),
                            UpdateNonNullableIGetSessions_Sessions_Nodes_SpeakersEntityNonNullableArray(
                                session,
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "speakers"),
                                entityIds)));
                }
                else
                {
                    session.SetEntity(
                        entityId,
                        new global::PullGraphQlSchema.GraphQL.State.SessionEntity(
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "title")),
                            DeserializeDateTimeOffset(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "startTime")),
                            DeserializeDateTimeOffset(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "endTime")),
                            DeserializeString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "description")),
                            UpdateNonNullableIGetSessions_Sessions_Nodes_SpeakersEntityNonNullableArray(
                                session,
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "speakers"),
                                entityIds)));
                }

                return entityId;
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.String DeserializeNonNullableString(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _stringParser.Parse(obj.Value.GetString()!);
        }

        private global::System.DateTimeOffset? DeserializeDateTimeOffset(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            return _dateTimeParser.Parse(obj.Value.GetString()!);
        }

        private global::System.String? DeserializeString(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            return _stringParser.Parse(obj.Value.GetString()!);
        }

        private global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId> UpdateNonNullableIGetSessions_Sessions_Nodes_SpeakersEntityNonNullableArray(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            var speakers = new global::System.Collections.Generic.List<global::StrawberryShake.EntityId>();

            foreach (global::System.Text.Json.JsonElement child in obj.Value.EnumerateArray())
            {
                speakers.Add(UpdateNonNullableIGetSessions_Sessions_Nodes_SpeakersEntity(
                    session,
                    child,
                    entityIds));
            }

            return speakers;
        }

        private global::StrawberryShake.EntityId UpdateNonNullableIGetSessions_Sessions_Nodes_SpeakersEntity(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            global::StrawberryShake.EntityId entityId = _idSerializer.Parse(obj.Value);
            entityIds.Add(entityId);


            if (entityId.Name.Equals(
                    "Speaker",
                    global::System.StringComparison.Ordinal))
            {
                if (session.CurrentSnapshot.TryGetEntity(
                        entityId,
                        out global::PullGraphQlSchema.GraphQL.State.SpeakerEntity? entity))
                {
                    session.SetEntity(
                        entityId,
                        new global::PullGraphQlSchema.GraphQL.State.SpeakerEntity(DeserializeNonNullableString(
                            global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                obj,
                                "name"))));
                }
                else
                {
                    session.SetEntity(
                        entityId,
                        new global::PullGraphQlSchema.GraphQL.State.SpeakerEntity(DeserializeNonNullableString(
                            global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                obj,
                                "name"))));
                }

                return entityId;
            }

            throw new global::System.NotSupportedException();
        }
    }
}


// SessionConnectionData.cs
#nullable enable

namespace PullGraphQlSchema.GraphQL.State
{
    /// <summary>
    /// A connection to a list of items.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class SessionConnectionData
    {
        public SessionConnectionData(
            global::System.String __typename,
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId>? nodes = null)
        {
            this.__typename = __typename
                 ?? throw new global::System.ArgumentNullException(nameof(__typename));
            Nodes = nodes;
        }

        public global::System.String __typename { get; }

        /// <summary>
        /// A flattened list of the nodes.
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId>? Nodes { get; }
    }
}


// ConferenceClient.cs
#nullable enable

namespace PullGraphQlSchema.GraphQL
{
    /// <summary>
    /// Represents the ConferenceClient GraphQL client
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class ConferenceClient
        : global::PullGraphQlSchema.GraphQL.IConferenceClient
    {
        private readonly global::PullGraphQlSchema.GraphQL.IGetSessionsQuery _getSessions;

        public ConferenceClient(global::PullGraphQlSchema.GraphQL.IGetSessionsQuery getSessions)
        {
            _getSessions = getSessions
                 ?? throw new global::System.ArgumentNullException(nameof(getSessions));
        }

        public static global::System.String ClientName => "ConferenceClient";

        public global::PullGraphQlSchema.GraphQL.IGetSessionsQuery GetSessions => _getSessions;
    }
}


// IConferenceClient.cs
#nullable enable

namespace PullGraphQlSchema.GraphQL
{
    /// <summary>
    /// Represents the ConferenceClient GraphQL client
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IConferenceClient
    {
        global::PullGraphQlSchema.GraphQL.IGetSessionsQuery GetSessions { get; }
    }
}


// ConferenceClientEntityIdFactory.cs
#nullable enable

namespace PullGraphQlSchema.GraphQL.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class ConferenceClientEntityIdFactory
        : global::StrawberryShake.IEntityIdSerializer
    {
        private static readonly global::System.Text.Json.JsonWriterOptions _options = new global::System.Text.Json.JsonWriterOptions(){ Indented = false };

        public global::StrawberryShake.EntityId Parse(global::System.Text.Json.JsonElement obj)
        {
            global::System.String __typename = obj
                .GetProperty("__typename")
                .GetString()!;

            return __typename switch
            {
                "Session" => ParseSessionEntityId(
                    obj,
                    __typename),
                "Speaker" => ParseSpeakerEntityId(
                    obj,
                    __typename),
                _ => throw new global::System.NotSupportedException()
            };
        }

        public global::System.String Format(global::StrawberryShake.EntityId entityId)
        {
            return entityId.Name switch
            {
                "Session" => FormatSessionEntityId(entityId),
                "Speaker" => FormatSpeakerEntityId(entityId),
                _ => throw new global::System.NotSupportedException()
            };
        }

        private global::StrawberryShake.EntityId ParseSessionEntityId(
            global::System.Text.Json.JsonElement obj,
            global::System.String type)
        {
            return new global::StrawberryShake.EntityId(
                type,
                obj
                    .GetProperty("id")
                    .GetString()!);
        }

        private global::System.String FormatSessionEntityId(global::StrawberryShake.EntityId entityId)
        {
            using var writer = new global::StrawberryShake.Internal.ArrayWriter();
            using var jsonWriter = new global::System.Text.Json.Utf8JsonWriter(
                writer,
                _options);
            jsonWriter.WriteStartObject();

            jsonWriter.WriteString(
                "__typename",
                entityId.Name);

            jsonWriter.WriteString(
                "id",
                (global::System.String)entityId.Value);
            jsonWriter.WriteEndObject();
            jsonWriter.Flush();

            return global::System.Text.Encoding.UTF8.GetString(
                writer.GetInternalBuffer(),
                0,
                writer.Length);
        }

        private global::StrawberryShake.EntityId ParseSpeakerEntityId(
            global::System.Text.Json.JsonElement obj,
            global::System.String type)
        {
            return new global::StrawberryShake.EntityId(
                type,
                obj
                    .GetProperty("id")
                    .GetString()!);
        }

        private global::System.String FormatSpeakerEntityId(global::StrawberryShake.EntityId entityId)
        {
            using var writer = new global::StrawberryShake.Internal.ArrayWriter();
            using var jsonWriter = new global::System.Text.Json.Utf8JsonWriter(
                writer,
                _options);
            jsonWriter.WriteStartObject();

            jsonWriter.WriteString(
                "__typename",
                entityId.Name);

            jsonWriter.WriteString(
                "id",
                (global::System.String)entityId.Value);
            jsonWriter.WriteEndObject();
            jsonWriter.Flush();

            return global::System.Text.Encoding.UTF8.GetString(
                writer.GetInternalBuffer(),
                0,
                writer.Length);
        }
    }
}


// ConferenceClientServiceCollectionExtensions.cs
#nullable enable

namespace Microsoft.Extensions.DependencyInjection
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public static partial class ConferenceClientServiceCollectionExtensions
    {
        public static global::StrawberryShake.IClientBuilder<global::PullGraphQlSchema.GraphQL.State.ConferenceClientStoreAccessor> AddConferenceClient(
            this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services,
            global::StrawberryShake.ExecutionStrategy strategy = global::StrawberryShake.ExecutionStrategy.NetworkOnly)
        {
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => 
                {
                    var serviceCollection = ConfigureClientDefault(
                        sp,
                        strategy);

                    return new ClientServiceProvider(
                        global::Microsoft.Extensions.DependencyInjection.ServiceCollectionContainerBuilderExtensions.BuildServiceProvider(serviceCollection));
                });

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => new global::PullGraphQlSchema.GraphQL.State.ConferenceClientStoreAccessor(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationStore>(
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IEntityStore>(
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IEntityIdSerializer>(
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Collections.Generic.IEnumerable<global::StrawberryShake.IOperationRequestFactory>>(
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Collections.Generic.IEnumerable<global::StrawberryShake.IOperationResultDataFactory>>(
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp))));

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::PullGraphQlSchema.GraphQL.GetSessionsQuery>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::PullGraphQlSchema.GraphQL.ConferenceClient>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::PullGraphQlSchema.GraphQL.IConferenceClient>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));

            return new global::StrawberryShake.ClientBuilder<global::PullGraphQlSchema.GraphQL.State.ConferenceClientStoreAccessor>(
                "ConferenceClient",
                services);
        }

        private static global::Microsoft.Extensions.DependencyInjection.IServiceCollection ConfigureClientDefault(
            global::System.IServiceProvider parentServices,
            global::StrawberryShake.ExecutionStrategy strategy = global::StrawberryShake.ExecutionStrategy.NetworkOnly)
        {
            var services = new global::Microsoft.Extensions.DependencyInjection.ServiceCollection();
            global::Microsoft.Extensions.DependencyInjection.Extensions.ServiceCollectionDescriptorExtensions.TryAddSingleton<global::StrawberryShake.IEntityStore, global::StrawberryShake.EntityStore>(services);
            global::Microsoft.Extensions.DependencyInjection.Extensions.ServiceCollectionDescriptorExtensions.TryAddSingleton<global::StrawberryShake.IOperationStore>(
                services,
                sp => new global::StrawberryShake.OperationStore(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IEntityStore>(sp)));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => 
                {
                    var clientFactory = global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Net.Http.IHttpClientFactory>(parentServices);
                    return new global::StrawberryShake.Transport.Http.HttpConnection(() => clientFactory.CreateClient("ConferenceClient"));
                });

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::PullGraphQlSchema.GraphQL.State.SessionEntity, global::PullGraphQlSchema.GraphQL.GetSessions_Sessions_Nodes_Session>, global::PullGraphQlSchema.GraphQL.State.GetSessions_Sessions_Nodes_SessionFromSessionEntityMapper>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::PullGraphQlSchema.GraphQL.State.SpeakerEntity, global::PullGraphQlSchema.GraphQL.GetSessions_Sessions_Nodes_Speakers_Speaker>, global::PullGraphQlSchema.GraphQL.State.GetSessions_Sessions_Nodes_Speakers_SpeakerFromSpeakerEntityMapper>(services);

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.StringSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.BooleanSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.ByteSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.ShortSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.IntSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.LongSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.FloatSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.DecimalSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.UrlSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.UuidSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.IdSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.DateTimeSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.DateSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.ByteArraySerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.TimeSpanSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializerResolver>(
                services,
                sp => new global::StrawberryShake.Serialization.SerializerResolver(
                    global::System.Linq.Enumerable.Concat(
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Collections.Generic.IEnumerable<global::StrawberryShake.Serialization.ISerializer>>(
                            parentServices),
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Collections.Generic.IEnumerable<global::StrawberryShake.Serialization.ISerializer>>(
                            sp))));

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory<global::PullGraphQlSchema.GraphQL.IGetSessionsResult>, global::PullGraphQlSchema.GraphQL.State.GetSessionsResultFactory>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory>(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultDataFactory<global::PullGraphQlSchema.GraphQL.IGetSessionsResult>>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationRequestFactory>(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::PullGraphQlSchema.GraphQL.IGetSessionsQuery>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::PullGraphQlSchema.GraphQL.IGetSessionsResult>, global::PullGraphQlSchema.GraphQL.State.GetSessionsBuilder>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationExecutor<global::PullGraphQlSchema.GraphQL.IGetSessionsResult>>(
                services,
                sp => new global::StrawberryShake.OperationExecutor<global::System.Text.Json.JsonDocument, global::PullGraphQlSchema.GraphQL.IGetSessionsResult>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.Transport.Http.HttpConnection>(sp),
                    () => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::PullGraphQlSchema.GraphQL.IGetSessionsResult>>(sp),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationStore>(sp),
                    strategy));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::PullGraphQlSchema.GraphQL.GetSessionsQuery>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::PullGraphQlSchema.GraphQL.IGetSessionsQuery>(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::PullGraphQlSchema.GraphQL.GetSessionsQuery>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityIdSerializer, global::PullGraphQlSchema.GraphQL.State.ConferenceClientEntityIdFactory>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::PullGraphQlSchema.GraphQL.ConferenceClient>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::PullGraphQlSchema.GraphQL.IConferenceClient>(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::PullGraphQlSchema.GraphQL.ConferenceClient>(sp));
            return services;
        }

        private class ClientServiceProvider
            : System.IServiceProvider
            , System.IDisposable
        {
            private readonly System.IServiceProvider _provider;

            public ClientServiceProvider(System.IServiceProvider provider)
            {
                _provider = provider;
            }

            public object? GetService(System.Type serviceType)
            {
                return _provider.GetService(serviceType);
            }

            public void Dispose()
            {
                if (_provider is System.IDisposable d)
                {
                    d.Dispose();
                }
            }
        }
    }
}


// ConferenceClientStoreAccessor.cs
#nullable enable

namespace PullGraphQlSchema.GraphQL.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class ConferenceClientStoreAccessor
        : global::StrawberryShake.StoreAccessor
    {
        public ConferenceClientStoreAccessor(
            global::StrawberryShake.IOperationStore operationStore,
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityIdSerializer entityIdSerializer,
            global::System.Collections.Generic.IEnumerable<global::StrawberryShake.IOperationRequestFactory> requestFactories,
            global::System.Collections.Generic.IEnumerable<global::StrawberryShake.IOperationResultDataFactory> resultDataFactories)
            : base(
                operationStore,
                entityStore,
                entityIdSerializer,
                requestFactories,
                resultDataFactories)
        {
        }
    }
}


