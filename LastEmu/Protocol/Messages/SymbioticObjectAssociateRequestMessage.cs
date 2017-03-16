using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class SymbioticObjectAssociateRequestMessage : NetworkMessage
	{
		public const uint Id = 6522;

		public uint symbioteUID;

		public byte symbiotePos;

		public uint hostUID;

		public byte hostPos;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6522;
			}
		}

		public SymbioticObjectAssociateRequestMessage()
		{
		}

		public SymbioticObjectAssociateRequestMessage(uint symbioteUID, byte symbiotePos, uint hostUID, byte hostPos)
		{
			this.symbioteUID = symbioteUID;
			this.symbiotePos = symbiotePos;
			this.hostUID = hostUID;
			this.hostPos = hostPos;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.symbioteUID = reader.ReadVarUhInt();
			this.symbiotePos = reader.ReadByte();
			this.hostUID = reader.ReadVarUhInt();
			this.hostPos = reader.ReadByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.symbioteUID);
			writer.WriteByte(this.symbiotePos);
			writer.WriteVarInt((int)this.hostUID);
			writer.WriteByte(this.hostPos);
		}
	}
}