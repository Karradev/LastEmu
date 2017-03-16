using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class ObjectEffectDuration : ObjectEffect
	{
		public const short Id = 75;

		public uint days;

		public sbyte hours;

		public sbyte minutes;

		public override short TypeId
		{
			get
			{
				return 75;
			}
		}

		public ObjectEffectDuration()
		{
		}

		public ObjectEffectDuration(uint actionId, uint days, sbyte hours, sbyte minutes) : base(actionId)
		{
			this.days = days;
			this.hours = hours;
			this.minutes = minutes;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.days = reader.ReadVarUhShort();
			this.hours = reader.ReadSByte();
			this.minutes = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((int)this.days);
			writer.WriteSByte(this.hours);
			writer.WriteSByte(this.minutes);
		}
	}
}