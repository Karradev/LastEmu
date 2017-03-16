using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GuildInfosUpgradeMessage : NetworkMessage
	{
		public const uint Id = 5636;

		public sbyte maxTaxCollectorsCount;

		public sbyte taxCollectorsCount;

		public uint taxCollectorLifePoints;

		public uint taxCollectorDamagesBonuses;

		public uint taxCollectorPods;

		public uint taxCollectorProspecting;

		public uint taxCollectorWisdom;

		public uint boostPoints;

		public uint[] spellId;

		public short[] spellLevel;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5636;
			}
		}

		public GuildInfosUpgradeMessage()
		{
		}

		public GuildInfosUpgradeMessage(sbyte maxTaxCollectorsCount, sbyte taxCollectorsCount, uint taxCollectorLifePoints, uint taxCollectorDamagesBonuses, uint taxCollectorPods, uint taxCollectorProspecting, uint taxCollectorWisdom, uint boostPoints, uint[] spellId, short[] spellLevel)
		{
			this.maxTaxCollectorsCount = maxTaxCollectorsCount;
			this.taxCollectorsCount = taxCollectorsCount;
			this.taxCollectorLifePoints = taxCollectorLifePoints;
			this.taxCollectorDamagesBonuses = taxCollectorDamagesBonuses;
			this.taxCollectorPods = taxCollectorPods;
			this.taxCollectorProspecting = taxCollectorProspecting;
			this.taxCollectorWisdom = taxCollectorWisdom;
			this.boostPoints = boostPoints;
			this.spellId = spellId;
			this.spellLevel = spellLevel;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.maxTaxCollectorsCount = reader.ReadSByte();
			this.taxCollectorsCount = reader.ReadSByte();
			this.taxCollectorLifePoints = reader.ReadVarUhShort();
			this.taxCollectorDamagesBonuses = reader.ReadVarUhShort();
			this.taxCollectorPods = reader.ReadVarUhShort();
			this.taxCollectorProspecting = reader.ReadVarUhShort();
			this.taxCollectorWisdom = reader.ReadVarUhShort();
			this.boostPoints = reader.ReadVarUhShort();
			ushort num = reader.ReadUShort();
			this.spellId = new uint[num];
			for (int i = 0; i < num; i++)
			{
				this.spellId[i] = reader.ReadVarUhShort();
			}
			num = reader.ReadUShort();
			this.spellLevel = new short[num];
			for (int j = 0; j < num; j++)
			{
				this.spellLevel[j] = reader.ReadShort();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.maxTaxCollectorsCount);
			writer.WriteSByte(this.taxCollectorsCount);
			writer.WriteVarShort((int)this.taxCollectorLifePoints);
			writer.WriteVarShort((int)this.taxCollectorDamagesBonuses);
			writer.WriteVarShort((int)this.taxCollectorPods);
			writer.WriteVarShort((int)this.taxCollectorProspecting);
			writer.WriteVarShort((int)this.taxCollectorWisdom);
			writer.WriteVarShort((int)this.boostPoints);
			writer.WriteShort((short)((int)this.spellId.Length));
			uint[] numArray = this.spellId;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteVarShort((int)numArray[i]);
			}
			writer.WriteShort((short)((int)this.spellLevel.Length));
			short[] numArray1 = this.spellLevel;
			for (int j = 0; j < (int)numArray1.Length; j++)
			{
				writer.WriteShort(numArray1[j]);
			}
		}
	}
}