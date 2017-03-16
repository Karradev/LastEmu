using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class TaxCollectorDialogQuestionExtendedMessage : TaxCollectorDialogQuestionBasicMessage
	{
		public const uint Id = 5615;

		public uint maxPods;

		public uint prospecting;

		public uint wisdom;

		public sbyte taxCollectorsCount;

		public int taxCollectorAttack;

		public uint kamas;

		public double experience;

		public uint pods;

		public uint itemsValue;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5615;
			}
		}

		public TaxCollectorDialogQuestionExtendedMessage()
		{
		}

		public TaxCollectorDialogQuestionExtendedMessage(BasicGuildInformations guildInfo, uint maxPods, uint prospecting, uint wisdom, sbyte taxCollectorsCount, int taxCollectorAttack, uint kamas, double experience, uint pods, uint itemsValue) : base(guildInfo)
		{
			this.maxPods = maxPods;
			this.prospecting = prospecting;
			this.wisdom = wisdom;
			this.taxCollectorsCount = taxCollectorsCount;
			this.taxCollectorAttack = taxCollectorAttack;
			this.kamas = kamas;
			this.experience = experience;
			this.pods = pods;
			this.itemsValue = itemsValue;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.maxPods = reader.ReadVarUhShort();
			this.prospecting = reader.ReadVarUhShort();
			this.wisdom = reader.ReadVarUhShort();
			this.taxCollectorsCount = reader.ReadSByte();
			this.taxCollectorAttack = reader.ReadInt();
			this.kamas = reader.ReadVarUhInt();
			this.experience = reader.ReadVarUhLong();
			this.pods = reader.ReadVarUhInt();
			this.itemsValue = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((int)this.maxPods);
			writer.WriteVarShort((int)this.prospecting);
			writer.WriteVarShort((int)this.wisdom);
			writer.WriteSByte(this.taxCollectorsCount);
			writer.WriteInt(this.taxCollectorAttack);
			writer.WriteVarInt((int)this.kamas);
			writer.WriteVarLong(this.experience);
			writer.WriteVarInt((int)this.pods);
			writer.WriteVarInt((int)this.itemsValue);
		}
	}
}