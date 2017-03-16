using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class SpouseGetInformationsMessage : NetworkMessage
	{
		public const uint Id = 6355;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6355;
			}
		}

		public SpouseGetInformationsMessage()
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