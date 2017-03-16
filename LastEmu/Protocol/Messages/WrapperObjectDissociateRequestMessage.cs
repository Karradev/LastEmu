using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class WrapperObjectDissociateRequestMessage : NetworkMessage
	{
		public const uint Id = 6524;

		public uint hostUID;

		public byte hostPos;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6524;
			}
		}

		public WrapperObjectDissociateRequestMessage()
		{
		}

		public WrapperObjectDissociateRequestMessage(uint hostUID, byte hostPos)
		{
			this.hostUID = hostUID;
			this.hostPos = hostPos;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.hostUID = reader.ReadVarUhInt();
			this.hostPos = reader.ReadByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.hostUID);
			writer.WriteByte(this.hostPos);
		}
	}
}