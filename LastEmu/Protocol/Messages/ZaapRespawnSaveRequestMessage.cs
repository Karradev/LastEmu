using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ZaapRespawnSaveRequestMessage : NetworkMessage
	{
		public const uint Id = 6572;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6572;
			}
		}

		public ZaapRespawnSaveRequestMessage()
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