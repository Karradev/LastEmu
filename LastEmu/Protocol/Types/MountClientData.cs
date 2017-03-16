using Protocol.IO;

using System;

namespace Protocol.Types
{
	public class MountClientData
	{
		public const short Id = 178;

		public bool sex;

		public bool isRideable;

		public bool isWild;

		public bool isFecondationReady;

		public bool useHarnessColors;

		public double id;

		public uint model;

		public int[] ancestor;

		public int[] behaviors;

		public string name;

		public int ownerId;

		public double experience;

		public double experienceForLevel;

		public double experienceForNextLevel;

		public sbyte level;

		public uint maxPods;

		public uint stamina;

		public uint staminaMax;

		public uint maturity;

		public uint maturityForAdult;

		public uint energy;

		public uint energyMax;

		public int serenity;

		public int aggressivityMax;

		public uint serenityMax;

		public uint love;

		public uint loveMax;

		public int fecondationTime;

		public int boostLimiter;

		public double boostMax;

		public int reproductionCount;

		public uint reproductionCountMax;

		public uint harnessGID;

		public ObjectEffectInteger[] effectList;

		public virtual short TypeId
		{
			get
			{
				return 178;
			}
		}

		public MountClientData()
		{
		}

		public MountClientData(bool sex, bool isRideable, bool isWild, bool isFecondationReady, bool useHarnessColors, double id, uint model, int[] ancestor, int[] behaviors, string name, int ownerId, double experience, double experienceForLevel, double experienceForNextLevel, sbyte level, uint maxPods, uint stamina, uint staminaMax, uint maturity, uint maturityForAdult, uint energy, uint energyMax, int serenity, int aggressivityMax, uint serenityMax, uint love, uint loveMax, int fecondationTime, int boostLimiter, double boostMax, int reproductionCount, uint reproductionCountMax, uint harnessGID, ObjectEffectInteger[] effectList)
		{
			this.sex = sex;
			this.isRideable = isRideable;
			this.isWild = isWild;
			this.isFecondationReady = isFecondationReady;
			this.useHarnessColors = useHarnessColors;
			this.id = id;
			this.model = model;
			this.ancestor = ancestor;
			this.behaviors = behaviors;
			this.name = name;
			this.ownerId = ownerId;
			this.experience = experience;
			this.experienceForLevel = experienceForLevel;
			this.experienceForNextLevel = experienceForNextLevel;
			this.level = level;
			this.maxPods = maxPods;
			this.stamina = stamina;
			this.staminaMax = staminaMax;
			this.maturity = maturity;
			this.maturityForAdult = maturityForAdult;
			this.energy = energy;
			this.energyMax = energyMax;
			this.serenity = serenity;
			this.aggressivityMax = aggressivityMax;
			this.serenityMax = serenityMax;
			this.love = love;
			this.loveMax = loveMax;
			this.fecondationTime = fecondationTime;
			this.boostLimiter = boostLimiter;
			this.boostMax = boostMax;
			this.reproductionCount = reproductionCount;
			this.reproductionCountMax = reproductionCountMax;
			this.harnessGID = harnessGID;
			this.effectList = effectList;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			byte num = reader.ReadByte();
			this.sex = BooleanByteWrapper.GetFlag(num, 0);
			this.isRideable = BooleanByteWrapper.GetFlag(num, 1);
			this.isWild = BooleanByteWrapper.GetFlag(num, 2);
			this.isFecondationReady = BooleanByteWrapper.GetFlag(num, 3);
			this.useHarnessColors = BooleanByteWrapper.GetFlag(num, 4);
			this.id = reader.ReadDouble();
			this.model = reader.ReadVarUhInt();
			ushort num1 = reader.ReadUShort();
			this.ancestor = new int[num1];
			for (int i = 0; i < num1; i++)
			{
				this.ancestor[i] = reader.ReadInt();
			}
			num1 = reader.ReadUShort();
			this.behaviors = new int[num1];
			for (int j = 0; j < num1; j++)
			{
				this.behaviors[j] = reader.ReadInt();
			}
			this.name = reader.ReadUTF();
			this.ownerId = reader.ReadInt();
			this.experience = reader.ReadVarUhLong();
			this.experienceForLevel = reader.ReadVarUhLong();
			this.experienceForNextLevel = reader.ReadDouble();
			this.level = reader.ReadSByte();
			this.maxPods = reader.ReadVarUhInt();
			this.stamina = reader.ReadVarUhInt();
			this.staminaMax = reader.ReadVarUhInt();
			this.maturity = reader.ReadVarUhInt();
			this.maturityForAdult = reader.ReadVarUhInt();
			this.energy = reader.ReadVarUhInt();
			this.energyMax = reader.ReadVarUhInt();
			this.serenity = reader.ReadInt();
			this.aggressivityMax = reader.ReadInt();
			this.serenityMax = reader.ReadVarUhInt();
			this.love = reader.ReadVarUhInt();
			this.loveMax = reader.ReadVarUhInt();
			this.fecondationTime = reader.ReadInt();
			this.boostLimiter = reader.ReadInt();
			this.boostMax = reader.ReadDouble();
			this.reproductionCount = reader.ReadInt();
			this.reproductionCountMax = reader.ReadVarUhInt();
			this.harnessGID = reader.ReadVarUhShort();
			num1 = reader.ReadUShort();
			this.effectList = new ObjectEffectInteger[num1];
			for (int k = 0; k < num1; k++)
			{
				this.effectList[k] = new ObjectEffectInteger();
				this.effectList[k].Deserialize(reader);
			}
		}

		public virtual void Serialize(IDataWriter writer)
		{
			byte num = BooleanByteWrapper.SetFlag(0, 0, this.sex);
			num = BooleanByteWrapper.SetFlag(num, 1, this.isRideable);
			num = BooleanByteWrapper.SetFlag(num, 2, this.isWild);
			num = BooleanByteWrapper.SetFlag(num, 3, this.isFecondationReady);
			writer.WriteByte(BooleanByteWrapper.SetFlag(num, 4, this.useHarnessColors));
			writer.WriteDouble(this.id);
			writer.WriteVarInt((int)this.model);
			writer.WriteShort((short)((int)this.ancestor.Length));
			int[] numArray = this.ancestor;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteInt(numArray[i]);
			}
			writer.WriteShort((short)((int)this.behaviors.Length));
			int[] numArray1 = this.behaviors;
			for (int j = 0; j < (int)numArray1.Length; j++)
			{
				writer.WriteInt(numArray1[j]);
			}
			writer.WriteUTF(this.name);
			writer.WriteInt(this.ownerId);
			writer.WriteVarLong(this.experience);
			writer.WriteVarLong(this.experienceForLevel);
			writer.WriteDouble(this.experienceForNextLevel);
			writer.WriteSByte(this.level);
			writer.WriteVarInt((int)this.maxPods);
			writer.WriteVarInt((int)this.stamina);
			writer.WriteVarInt((int)this.staminaMax);
			writer.WriteVarInt((int)this.maturity);
			writer.WriteVarInt((int)this.maturityForAdult);
			writer.WriteVarInt((int)this.energy);
			writer.WriteVarInt((int)this.energyMax);
			writer.WriteInt(this.serenity);
			writer.WriteInt(this.aggressivityMax);
			writer.WriteVarInt((int)this.serenityMax);
			writer.WriteVarInt((int)this.love);
			writer.WriteVarInt((int)this.loveMax);
			writer.WriteInt(this.fecondationTime);
			writer.WriteInt(this.boostLimiter);
			writer.WriteDouble(this.boostMax);
			writer.WriteInt(this.reproductionCount);
			writer.WriteVarInt((int)this.reproductionCountMax);
			writer.WriteVarShort((int)this.harnessGID);
			writer.WriteShort((short)((int)this.effectList.Length));
			ObjectEffectInteger[] objectEffectIntegerArray = this.effectList;
			for (int k = 0; k < (int)objectEffectIntegerArray.Length; k++)
			{
				objectEffectIntegerArray[k].Serialize(writer);
			}
		}
	}
}