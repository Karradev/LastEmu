using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class ObjectEffectInteger : ObjectEffect
	{
		public const short Id = 70;

		public uint @value;

		public override short TypeId
		{
			get
			{
				return 70;
			}
		}

		public ObjectEffectInteger()
		{
		}

		public ObjectEffectInteger(uint actionId, uint value) : base(actionId)
		{
			this.@value = value;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.@value = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((int)this.@value);
		}
	}
}