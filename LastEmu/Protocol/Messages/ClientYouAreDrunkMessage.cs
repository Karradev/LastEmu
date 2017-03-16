using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class ClientYouAreDrunkMessage : DebugInClientMessage
	{
		public const uint Id = 6594;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6594;
			}
		}

		public ClientYouAreDrunkMessage()
		{
		}

		public ClientYouAreDrunkMessage(sbyte level, string message) : base(level, message)
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