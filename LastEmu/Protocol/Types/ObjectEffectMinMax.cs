using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class ObjectEffectMinMax : ObjectEffect
	{
		public const short Id = 82;

		public uint min;

		public uint max;

		public override short TypeId
		{
			get
			{
				return 82;
			}
		}

		public ObjectEffectMinMax()
		{
		}

		public ObjectEffectMinMax(uint actionId, uint min, uint max) : base(actionId)
		{
			this.min = min;
			this.max = max;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.min = reader.ReadVarUhInt();
			this.max = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((int)this.min);
			writer.WriteVarInt((int)this.max);
		}
	}
}