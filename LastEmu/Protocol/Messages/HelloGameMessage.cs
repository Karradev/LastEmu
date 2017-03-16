using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class HelloGameMessage : NetworkMessage
	{
		public const uint Id = 101;

		public override uint ProtocolId
		{
			get
			{
				return (uint)101;
			}
		}

		public HelloGameMessage()
		{
		}

		public override void Deserialize(IDataReader reader)
		{
		}

		public override void Serialize(IDataWriter writer)
		{
		}
	}
}