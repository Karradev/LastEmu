using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class InteractiveUseEndedMessage : NetworkMessage
	{
		public const uint Id = 6112;

		public uint elemId;

		public uint skillId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6112;
			}
		}

		public InteractiveUseEndedMessage()
		{
		}

		public InteractiveUseEndedMessage(uint elemId, uint skillId)
		{
			this.elemId = elemId;
			this.skillId = skillId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.elemId = reader.ReadVarUhInt();
			this.skillId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.elemId);
			writer.WriteVarShort((int)this.skillId);
		}
	}
}