using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class DareInformations
	{
		public const short Id = 502;

		public double dareId;

		public CharacterBasicMinimalInformations creator;

		public int subscriptionFee;

		public int jackpot;

		public ushort maxCountWinners;

		public double endDate;

		public bool isPrivate;

		public uint guildId;

		public uint allianceId;

		public DareCriteria[] criterions;

		public double startDate;

		public virtual short TypeId
		{
			get
			{
				return 502;
			}
		}

		public DareInformations()
		{
		}

		public DareInformations(double dareId, CharacterBasicMinimalInformations creator, int subscriptionFee, int jackpot, ushort maxCountWinners, double endDate, bool isPrivate, uint guildId, uint allianceId, DareCriteria[] criterions, double startDate)
		{
			this.dareId = dareId;
			this.creator = creator;
			this.subscriptionFee = subscriptionFee;
			this.jackpot = jackpot;
			this.maxCountWinners = maxCountWinners;
			this.endDate = endDate;
			this.isPrivate = isPrivate;
			this.guildId = guildId;
			this.allianceId = allianceId;
			this.criterions = criterions;
			this.startDate = startDate;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.dareId = reader.ReadDouble();
			this.creator = new CharacterBasicMinimalInformations();
			this.creator.Deserialize(reader);
			this.subscriptionFee = reader.ReadInt();
			this.jackpot = reader.ReadInt();
			this.maxCountWinners = reader.ReadUShort();
			this.endDate = reader.ReadDouble();
			this.isPrivate = reader.ReadBoolean();
			this.guildId = reader.ReadVarUhInt();
			this.allianceId = reader.ReadVarUhInt();
			ushort num = reader.ReadUShort();
			this.criterions = new DareCriteria[num];
			for (int i = 0; i < num; i++)
			{
				this.criterions[i] = new DareCriteria();
				this.criterions[i].Deserialize(reader);
			}
			this.startDate = reader.ReadDouble();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(this.dareId);
			this.creator.Serialize(writer);
			writer.WriteInt(this.subscriptionFee);
			writer.WriteInt(this.jackpot);
			writer.WriteUShort(this.maxCountWinners);
			writer.WriteDouble(this.endDate);
			writer.WriteBoolean(this.isPrivate);
			writer.WriteVarInt((int)this.guildId);
			writer.WriteVarInt((int)this.allianceId);
			writer.WriteShort((short)((int)this.criterions.Length));
			DareCriteria[] dareCriteriaArray = this.criterions;
			for (int i = 0; i < (int)dareCriteriaArray.Length; i++)
			{
				dareCriteriaArray[i].Serialize(writer);
			}
			writer.WriteDouble(this.startDate);
		}
	}
}