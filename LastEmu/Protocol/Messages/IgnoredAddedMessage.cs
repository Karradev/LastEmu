using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class IgnoredAddedMessage : NetworkMessage
	{
		public const uint Id = 5678;

		public IgnoredInformations ignoreAdded;

		public bool session;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5678;
			}
		}

		public IgnoredAddedMessage()
		{
		}

		public IgnoredAddedMessage(IgnoredInformations ignoreAdded, bool session)
		{
			this.ignoreAdded = ignoreAdded;
			this.session = session;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.ignoreAdded = ProtocolTypeManager.GetInstance<IgnoredInformations>(reader.ReadUShort());
			this.ignoreAdded.Deserialize(reader);
			this.session = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort(this.ignoreAdded.TypeId);
			this.ignoreAdded.Serialize(writer);
			writer.WriteBoolean(this.session);
		}
	}
}