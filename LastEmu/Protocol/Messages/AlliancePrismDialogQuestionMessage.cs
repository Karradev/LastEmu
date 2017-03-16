using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class AlliancePrismDialogQuestionMessage : NetworkMessage
	{
		public const uint Id = 6448;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6448;
			}
		}

		public AlliancePrismDialogQuestionMessage()
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