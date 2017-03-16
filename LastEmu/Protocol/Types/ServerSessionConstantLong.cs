using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class ServerSessionConstantLong : ServerSessionConstant
	{
		public const short Id = 429;

		public double @value;

		public override short TypeId
		{
			get
			{
				return 429;
			}
		}

		public ServerSessionConstantLong()
		{
		}

		public ServerSessionConstantLong(uint id, double value) : base(id)
		{
			this.@value = value;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.@value = reader.ReadDouble();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(this.@value);
		}
	}
}