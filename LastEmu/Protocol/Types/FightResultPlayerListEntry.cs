using Protocol.IO;

using System;

namespace Protocol.Types
{
	public class FightResultPlayerListEntry : FightResultFighterListEntry
	{
		public const short Id = 24;

		public byte level;

		public FightResultAdditionalData[] additional;

		public override short TypeId
		{
			get
			{
				return 24;
			}
		}

		public FightResultPlayerListEntry()
		{
		}

		public FightResultPlayerListEntry(uint outcome, sbyte wave, FightLoot rewards, double id, bool alive, byte level, FightResultAdditionalData[] additional) : base(outcome, wave, rewards, id, alive)
		{
			this.level = level;
			this.additional = additional;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.level = reader.ReadByte();
			ushort num = reader.ReadUShort();
			this.additional = new FightResultAdditionalData[num];
			for (int i = 0; i < num; i++)
			{
				this.additional[i] = ProtocolTypeManager.GetInstance<FightResultAdditionalData>(reader.ReadUShort());
				this.additional[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(this.level);
			writer.WriteShort((short)((int)this.additional.Length));
			FightResultAdditionalData[] fightResultAdditionalDataArray = this.additional;
			for (int i = 0; i < (int)fightResultAdditionalDataArray.Length; i++)
			{
				FightResultAdditionalData fightResultAdditionalDatum = fightResultAdditionalDataArray[i];
				writer.WriteShort(fightResultAdditionalDatum.TypeId);
				fightResultAdditionalDatum.Serialize(writer);
			}
		}
	}
}