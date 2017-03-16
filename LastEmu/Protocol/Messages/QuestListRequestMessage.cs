using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class QuestListRequestMessage : NetworkMessage
	{
		public const uint Id = 5623;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5623;
			}
		}

		public QuestListRequestMessage()
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