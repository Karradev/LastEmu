using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class HumanOptionEmote : HumanOption
	{
		public const short Id = 407;

		public byte emoteId;

		public double emoteStartTime;

		public override short TypeId
		{
			get
			{
				return 407;
			}
		}

		public HumanOptionEmote()
		{
		}

		public HumanOptionEmote(byte emoteId, double emoteStartTime)
		{
			this.emoteId = emoteId;
			this.emoteStartTime = emoteStartTime;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.emoteId = reader.ReadByte();
			this.emoteStartTime = reader.ReadDouble();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(this.emoteId);
			writer.WriteDouble(this.emoteStartTime);
		}
	}
}