using Protocol.IO;

using System;

namespace Protocol.Types
{
	public class GameFightFighterLightInformations
	{
		public const short Id = 413;

		public bool sex;

		public bool alive;

		public double id;

		public sbyte wave;

		public uint level;

		public sbyte breed;

		public virtual short TypeId
		{
			get
			{
				return 413;
			}
		}

		public GameFightFighterLightInformations()
		{
		}

		public GameFightFighterLightInformations(bool sex, bool alive, double id, sbyte wave, uint level, sbyte breed)
		{
			this.sex = sex;
			this.alive = alive;
			this.id = id;
			this.wave = wave;
			this.level = level;
			this.breed = breed;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			byte num = reader.ReadByte();
			this.sex = BooleanByteWrapper.GetFlag(num, 0);
			this.alive = BooleanByteWrapper.GetFlag(num, 1);
			this.id = reader.ReadDouble();
			this.wave = reader.ReadSByte();
			this.level = reader.ReadVarUhShort();
			this.breed = reader.ReadSByte();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			byte num = BooleanByteWrapper.SetFlag(0, 0, this.sex);
			writer.WriteByte(BooleanByteWrapper.SetFlag(num, 1, this.alive));
			writer.WriteDouble(this.id);
			writer.WriteSByte(this.wave);
			writer.WriteVarShort((int)this.level);
			writer.WriteSByte(this.breed);
		}
	}
}