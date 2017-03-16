using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class MimicryObjectEraseRequestMessage : NetworkMessage
	{
		public const uint Id = 6457;

		public uint hostUID;

		public byte hostPos;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6457;
			}
		}

		public MimicryObjectEraseRequestMessage()
		{
		}

		public MimicryObjectEraseRequestMessage(uint hostUID, byte hostPos)
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