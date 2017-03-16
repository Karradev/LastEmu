using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class MountEmoteIconUsedOkMessage : NetworkMessage
	{
		public const uint Id = 5978;

		public int mountId;

		public sbyte reactionType;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5978;
			}
		}

		public MountEmoteIconUsedOkMessage()
		{
		}

		public MountEmoteIconUsedOkMessage(int mountId, sbyte reactionType)
		{
			this.mountId = mountId;
			this.reactionType = reactionType;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.mountId = reader.ReadVarInt();
			this.reactionType = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt(this.mountId);
			writer.WriteSByte(this.reactionType);
		}
	}
}