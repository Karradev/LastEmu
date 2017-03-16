using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class UpdateMountIntBoost : UpdateMountBoost
	{
		public const short Id = 357;

		public int @value;

		public override short TypeId
		{
			get
			{
				return 357;
			}
		}

		public UpdateMountIntBoost()
		{
		}

		public UpdateMountIntBoost(sbyte type, int value) : base(type)
		{
			this.@value = value;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.@value = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(this.@value);
		}
	}
}