using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class InteractiveUseRequestMessage : NetworkMessage
	{
		public const uint Id = 5001;

		public uint elemId;

		public uint skillInstanceUid;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5001;
			}
		}

		public InteractiveUseRequestMessage()
		{
		}

		public InteractiveUseRequestMessage(uint elemId, uint skillInstanceUid)
		{
			this.elemId = elemId;
			this.skillInstanceUid = skillInstanceUid;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.elemId = reader.ReadVarUhInt();
			this.skillInstanceUid = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.elemId);
			writer.WriteVarInt((int)this.skillInstanceUid);
		}
	}
}