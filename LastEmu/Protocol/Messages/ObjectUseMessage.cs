using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ObjectUseMessage : NetworkMessage
	{
		public const uint Id = 3019;

		public uint objectUID;

		public override uint ProtocolId
		{
			get
			{
				return (uint)3019;
			}
		}

		public ObjectUseMessage()
		{
		}

		public ObjectUseMessage(uint objectUID)
		{
			this.objectUID = objectUID;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.objectUID = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.objectUID);
		}
	}
}