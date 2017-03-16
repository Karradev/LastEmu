using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class AdminQuietCommandMessage : AdminCommandMessage
	{
		public const uint Id = 5662;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5662;
			}
		}

		public AdminQuietCommandMessage()
		{
		}

		public AdminQuietCommandMessage(string content) : base(content)
		{
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
		}
	}
}