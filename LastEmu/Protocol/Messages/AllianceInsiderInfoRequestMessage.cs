using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class AllianceInsiderInfoRequestMessage : NetworkMessage
	{
		public const uint Id = 6417;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6417;
			}
		}

		public AllianceInsiderInfoRequestMessage()
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