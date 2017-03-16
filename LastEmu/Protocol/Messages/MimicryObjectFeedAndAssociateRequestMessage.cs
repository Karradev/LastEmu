using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class MimicryObjectFeedAndAssociateRequestMessage : SymbioticObjectAssociateRequestMessage
	{
		public const uint Id = 6460;

		public uint foodUID;

		public byte foodPos;

		public bool preview;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6460;
			}
		}

		public MimicryObjectFeedAndAssociateRequestMessage()
		{
		}

		public MimicryObjectFeedAndAssociateRequestMessage(uint symbioteUID, byte symbiotePos, uint hostUID, byte hostPos, uint foodUID, byte foodPos, bool preview) : base(symbioteUID, symbiotePos, hostUID, hostPos)
		{
			this.foodUID = foodUID;
			this.foodPos = foodPos;
			this.preview = preview;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.foodUID = reader.ReadVarUhInt();
			this.foodPos = reader.ReadByte();
			this.preview = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((int)this.foodUID);
			writer.WriteByte(this.foodPos);
			writer.WriteBoolean(this.preview);
		}
	}
}