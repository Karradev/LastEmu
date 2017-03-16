using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class ServerSessionConstantInteger : ServerSessionConstant
	{
		public const short Id = 433;

		public int @value;

		public override short TypeId
		{
			get
			{
				return 433;
			}
		}

		public ServerSessionConstantInteger()
		{
		}

		public ServerSessionConstantInteger(uint id, int value) : base(id)
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