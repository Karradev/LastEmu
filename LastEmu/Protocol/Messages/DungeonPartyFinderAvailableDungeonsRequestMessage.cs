using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class DungeonPartyFinderAvailableDungeonsRequestMessage : NetworkMessage
	{
		public const uint Id = 6240;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6240;
			}
		}

		public DungeonPartyFinderAvailableDungeonsRequestMessage()
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