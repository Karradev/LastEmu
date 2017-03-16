using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GameActionFightMarkCellsMessage : AbstractGameActionMessage
	{
		public const uint Id = 5540;

		public GameActionMark mark;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5540;
			}
		}

		public GameActionFightMarkCellsMessage()
		{
		}

		public GameActionFightMarkCellsMessage(uint actionId, double sourceId, GameActionMark mark) : base(actionId, sourceId)
		{
			this.mark = mark;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.mark = new GameActionMark();
			this.mark.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			this.mark.Serialize(writer);
		}
	}
}