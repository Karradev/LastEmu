using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class PlayerStatusExtended : PlayerStatus
	{
		public const short Id = 414;

		public string message;

		public override short TypeId
		{
			get
			{
				return 414;
			}
		}

		public PlayerStatusExtended()
		{
		}

		public PlayerStatusExtended(sbyte statusId, string message) : base(statusId)
		{
			this.message = message;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.message = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUTF(this.message);
		}
	}
}