using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class KrosmasterAuthTokenRequestMessage : NetworkMessage
	{
		public const uint Id = 6346;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6346;
			}
		}

		public KrosmasterAuthTokenRequestMessage()
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