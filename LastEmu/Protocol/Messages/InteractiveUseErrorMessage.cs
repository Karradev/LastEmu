using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class InteractiveUseErrorMessage : NetworkMessage
	{
		public const uint Id = 6384;

		public uint elemId;

		public uint skillInstanceUid;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6384;
			}
		}

		public InteractiveUseErrorMessage()
		{
		}

		public InteractiveUseErrorMessage(uint elemId, uint skillInstanceUid)
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