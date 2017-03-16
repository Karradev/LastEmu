using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class ObjectEffectDate : ObjectEffect
	{
		public const short Id = 72;

		public uint year;

		public sbyte month;

		public sbyte day;

		public sbyte hour;

		public sbyte minute;

		public override short TypeId
		{
			get
			{
				return 72;
			}
		}

		public ObjectEffectDate()
		{
		}

		public ObjectEffectDate(uint actionId, uint year, sbyte month, sbyte day, sbyte hour, sbyte minute) : base(actionId)
		{
			this.year = year;
			this.month = month;
			this.day = day;
			this.hour = hour;
			this.minute = minute;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.year = reader.ReadVarUhShort();
			this.month = reader.ReadSByte();
			this.day = reader.ReadSByte();
			this.hour = reader.ReadSByte();
			this.minute = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((int)this.year);
			writer.WriteSByte(this.month);
			writer.WriteSByte(this.day);
			writer.WriteSByte(this.hour);
			writer.WriteSByte(this.minute);
		}
	}
}