using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class DungeonPartyFinderRegisterErrorMessage : NetworkMessage
	{
		public const uint Id = 6243;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6243;
			}
		}

		public DungeonPartyFinderRegisterErrorMessage()
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