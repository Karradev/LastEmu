using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class ServerSessionConstantString : ServerSessionConstant
	{
		public const short Id = 436;

		public string @value;

		public override short TypeId
		{
			get
			{
				return 436;
			}
		}

		public ServerSessionConstantString()
		{
		}

		public ServerSessionConstantString(uint id, string value) : base(id)
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