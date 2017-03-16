using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class ObjectEffectString : ObjectEffect
	{
		public const short Id = 74;

		public string @value;

		public override short TypeId
		{
			get
			{
				return 74;
			}
		}

		public ObjectEffectString()
		{
		}

		public ObjectEffectString(uint actionId, string value) : base(actionId)
		{
			this.@value = value;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.@value = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUTF(this.@value);
		}
	}
}