using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class MapRunningFightListRequestMessage : NetworkMessage
	{
		public const uint Id = 5742;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5742;
			}
		}

		public MapRunningFightListRequestMessage()
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